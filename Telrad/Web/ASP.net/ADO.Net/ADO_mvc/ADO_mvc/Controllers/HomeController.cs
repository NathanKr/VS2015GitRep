using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using ADO_mvc.Logic;
using ADO_mvc.Models;

namespace ADO_mvc.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]            
        public ActionResult AddEntry(string firstNameUser, string lastNameUser)
        {
            string strConnectionString = AdoHelper.GetConnectionString();



            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Table1 ([FirstName], [LastName]) ");
                sb.Append("VALUES (@FirstName, @LastName);");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstNameUser);
                    command.Parameters.AddWithValue("@LastName", lastNameUser);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }


            

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            List<User> list=null;

            try
            {
                list = getUserList();
            }
            catch (SqlException e)
            {
               ViewBag.error =  e.ToString();
            }



            return View(list);
        }

        private static List<User> getUserList()
        {
            List<User> list = new List<User>();

            string strConnectionString = AdoHelper.GetConnectionString();


            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * from Table1");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new User
                            {
                                Id = reader.GetInt32(0),//coulmn index
                                FirstName = reader.GetString(1),//coulmn index
                                LastName = reader.GetString(2)
                            });
                        }
                    }
                }

                return list;
            }
        }
    }
}