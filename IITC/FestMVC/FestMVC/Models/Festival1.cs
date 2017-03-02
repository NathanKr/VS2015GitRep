using FestMvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FestMVC.Models
{
    public class Festival1
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public long FesivalManagerId { get; set; }

        /*
          navigation properties
          virtual for lazy load
        */
        public virtual ICollection<Event> Events { get; set; }
    }
}