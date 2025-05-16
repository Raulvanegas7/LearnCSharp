using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ConsoleApp.DTOs;
using ConsoleApp.Service;

namespace ConsoleApp.metodo
{
    public class ReceiveServices
    {
        public static List<ServicesDto> AllServices(List<ServiceWip> myServices)
        {
            List<ServicesDto> findServices = myServices.Select(x => new ServicesDto()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Available = x.Available,
                Price = x.Price,
                Tags = x.Metadata.Tags,
                Location = x.Provider.Location
            }).ToList();

            return findServices;
        }

        public static List<ServiceWip> SeviceDate(List<ServiceWip> serviceData)
        {
            DateTime fecha = new DateTime(2024, 06, 01);
            List<ServiceWip> serviceByDate = serviceData.Where(x => x.Metadata.UpdatedAt > fecha).ToList();
            return serviceByDate;
        }
    }
}