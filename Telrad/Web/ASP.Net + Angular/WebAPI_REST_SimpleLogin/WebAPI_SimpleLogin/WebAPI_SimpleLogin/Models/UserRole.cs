using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_SimpleLogin.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}