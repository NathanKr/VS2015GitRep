using System.Collections.Generic;

namespace BlogsMVC_EF.Models.Models
{
    public class Blog
    {
        public long Id { get; set; }//primary key
        public string Title { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}