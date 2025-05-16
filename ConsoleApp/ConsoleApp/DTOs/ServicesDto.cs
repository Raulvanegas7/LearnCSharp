using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.DTOs
{
    public class ServicesDto
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}
        public bool Available {get; set;}
        public List<TagEnum> Tags {get; set;}
        public string Location {get; set;}
    }
}