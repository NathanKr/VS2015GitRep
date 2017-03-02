using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FestMVC.Models
{
    public class Category
    {
        public long Id { get; set; }

        [Display(Name = "שם")]
        public string Name { get; set; }
    }
}