using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Theater
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<string> Movies { get; set; }
        

    }
}