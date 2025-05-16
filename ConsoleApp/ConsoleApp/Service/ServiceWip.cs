using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Service
{
    public class ServiceWip
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}
        public bool Available {get; set;}
        public ProviderData Provider {get; set;}
        public MetadataInfo Metadata {get; set;}

    }
        public class ProviderData 
        {
            public string Name {get; set;}
            public float Rating {get; set;}
            public string Location {get; set;}
        }
        public class MetadataInfo
        {
            public DateTime CreatedAt {get; set;}
            public DateTime UpdatedAt {get; set;}
            public List<TagEnum> Tags {get; set;}
        }
}