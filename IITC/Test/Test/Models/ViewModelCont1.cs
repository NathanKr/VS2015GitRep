using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class ViewModelAddThree
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int Number3 { get; set; }
    }

    public class ViewModelAdd
    {
        [Range(1, 100)]
        public int Number { get; set; }
    }

    public class ViewModelResult
    {
        public int Result { get; set; }
    }

    public class ViewModelResultRand
    {
        public int Result { get; set; }
        public int Random { get; set; }
    }

    public class ViewModelFile
    {
        [Required]
        public HttpPostedFileBase File { get; set; }
    }
}