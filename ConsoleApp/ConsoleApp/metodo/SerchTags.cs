using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp.DTOs;

namespace ConsoleApp.metodo
{
    public class SerchTags
    {
        public static List<ServicesDto> FindTags (List<ServicesDto> servicesTags)
        {
            List<ServicesDto> allTags = servicesTags.Where(x => x.Tags.Contains(TagEnum.Seo)).ToList();
            return allTags;
            
        }
    }
}