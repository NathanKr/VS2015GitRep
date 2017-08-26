using System.Collections.Generic;

namespace BlogsMVC_EF.Models
{
    public class Blog
    {
        public long Id { get; set; }//primary key
        public string Title { get; set; }

       // this cause web api problem public virtual ICollection<Post> Posts { get; set; } 
    }
}