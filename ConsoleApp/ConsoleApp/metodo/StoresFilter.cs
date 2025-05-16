using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ConsoleApp;
using ConsoleApp.DTOs;
using ConsoleApp.Stores;

namespace ConsoleApp.metodo
{
    public class StoresFilter
    {
        public static List<ModelStores> ShowStores(List<ModelStores> storesPara)
        {
            List<ModelStores> myStores = storesPara.Where(x => x.Status == StatusEnum.SUSPENDED && x.Settings.SupportedPaymentMethods.Contains(PaymentEnum.PAYPAL)).ToList();
            return myStores;
        }

        public static List<ModelStores> AtChicago(List<ModelStores> inChicago)
        {
            List<ModelStores> storeCity = inChicago.Where(x => x.Location.City == "Chicago").ToList();
            return storeCity;
        }

        public static List<ModelStores> StoreDate(List<ModelStores> storeDataDate)
        {
            DateTime fecha = new DateTime(2022, 08, 01);
            List<ModelStores> storeByDate = storeDataDate.Where(x => x.CreatedAt > fecha).ToList();
            return storeByDate;
        }

        public static List<string> findEmails(List<ModelStores> storeData)
        {
            List<string> ownerEmails = [];

            foreach(var obj in storeData)
            {
                ownerEmails.Add(obj.Owner.Contact.Email);
            }

            return ownerEmails;
        }

        public static List<StoreDto> OwnerInfo (List<ModelStores> dataStoreOrigi)
        {
            List<StoreDto> findOwnerInfo = dataStoreOrigi.Select(x => new StoreDto()
            {
                Name = x.Name,
                Email = x.Owner.Contact.Email,
                Address = x.Location.Address,
                Status = x.Status,
                City = x.Location.City
            }).Where(x => x.Status == StatusEnum.ACTIVE).ToList();
            
            return findOwnerInfo;
        }
        
    }
}

