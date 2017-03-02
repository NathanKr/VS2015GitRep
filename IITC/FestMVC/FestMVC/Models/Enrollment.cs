using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestMVC.Models
{
    public class Enrollment
    {
        public long Id { get; set; }

        public string UserId { get; set; }

        public long EventId { get; set; }
    }
}