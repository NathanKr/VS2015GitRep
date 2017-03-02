using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FestMVC.Models
{
    public class Room
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Location  { get; set; }

        public int Capacity  { get; set; }
    }
}