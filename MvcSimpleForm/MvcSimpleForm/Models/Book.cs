using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSimpleForm.Models
{
    public class Book
    {
        // --- primary key
        public int Id { get; set; }

        public string Name { get; set; }

        public int Pages { get; set; }
    }
}