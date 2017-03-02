using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestMvc.Models
{
    public class FestivalN
    {                  
                public long Id { get; set; }
                public string Name { get; set; }
                public string Location { get; set; }
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
                public long FesivalManagerId { get; set; }
    }
}