using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxExample.Models
{
    public class TestModel
    {
        [Required]
        [DisplayName("Number of scores")]
        public int ScoresNum { get; set; }
    }

    public class TestModelWithFileUpload
    {
        [Required]
        [DisplayName("Number of scores")]
        public int ScoresNum { get; set; }

        public string File{ get; set; }
    }
}