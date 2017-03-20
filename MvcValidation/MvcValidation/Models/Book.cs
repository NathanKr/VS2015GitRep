﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcValidation.Models
{
    public class Book
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}