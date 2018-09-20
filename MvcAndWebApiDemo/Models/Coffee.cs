using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAndWebApiDemo.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }

        public int CompanyId { get; set; } 
        public Company Company { get; set; } 
    }
}