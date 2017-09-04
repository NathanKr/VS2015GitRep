using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI_SimpleLogin.Logic;
using WebAPI_SimpleLogin.Models;

namespace WebAPI_SimpleLogin.Controllers.api
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext m_db = new ApplicationDbContext();

        // GET /api/users
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return m_db.AppUsers;
        }


        // POST /api/users/register
        [HttpPost]
        public IHttpActionResult Register(User user)
        {
            if (!validationIsOk(user))
            {
                return BadRequest();
            }

            if(m_db.AppUsers.Any(usr => usr.Email == user.Email))
            {
                return Conflict();
            }


            m_db.AppUsers.Add(user);
            m_db.SaveChanges();
            
            // later we might replace with JWT
            return CreatedAtRoute(
                "ActionApi",
                new { id = user.Id },
                new Token { UserId = user.Id });
        }


        // POST /api/users/login
        [HttpPost]
        public IHttpActionResult Login(UserLogin userLogin)
        {
            if (!validationIsOk(userLogin)){
                return BadRequest();
            }

            User user = m_db.AppUsers.SingleOrDefault(usr => 
            (userLogin.Email == usr.Email) &&
            (userLogin.Password == usr.Password));

            if (user == null){
                return NotFound();
            }

            // later we might replace with JWT
            return Ok(new Token { UserId = user.Id});
        }

        private bool validationIsOk(User user)
        {
            bool bIsValid = (user != null) &&
                            validationIsOk(new UserLogin {
                                Email = user.Email ,
                                Password = user.Password}) &&
                                !string.IsNullOrEmpty(user.Name);

            return bIsValid;
        }


        private bool validationIsOk(UserLogin userLogin)
        {
            bool bIsValid = (userLogin != null) &&
                            !string.IsNullOrEmpty(userLogin.Email) &&
                            !string.IsNullOrEmpty(userLogin.Password);

            return bIsValid;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                m_db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}