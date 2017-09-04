using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_With_EF.Models
{
    public class Post
    {
        public long Id { get; set; }//primary key
        public string Title { get; set; }
        public string Content { get; set; }

        public long BlogId { get; set; }//forign key

    }
}