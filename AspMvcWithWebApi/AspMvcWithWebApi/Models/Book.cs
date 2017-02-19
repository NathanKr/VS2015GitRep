using AspMvcWithWebApi.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMvcWithWebApi.Models
{
    public class Book
    {
        public long Id { get; set; }

        [LessonFile]
        public string File { get; set; }

        public LessonEnums Type { get; set; }

        public int PagesNum { get; set; }
    }
}