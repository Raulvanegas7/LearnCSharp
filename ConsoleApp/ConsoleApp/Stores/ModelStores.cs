namespace ConsoleApp.Stores
{
    public class ModelStores
    {
        public string Id {get; set;}
        public string Name {get; set;}
        public StatusEnum Status {get; set;}
        public DateTime CreatedAt {get; set;}
        public LocationClass Location {get; set;}
        public OwnerClass Owner {get; set;}
        public SettingsClass Settings {get; set;}
    }

    public class LocationClass
    {
        public string Address {get; set;}
        public string City {get; set;}
        public string Country {get; set;}
        public CoordinatesSubClass Coordinates {get; set;}
    }

    public class CoordinatesSubClass
    {
        public double Latitude {get; set;}
        public double Longitude {get; set;}
    }

    public class OwnerClass
    {
        public string Id {get; set;}
        public string FullName {get; set;}
        public ContactSubClass Contact {get; set;}
    }

    public class ContactSubClass
    {
        public string Email {get; set;}
        public string Phone {get; set;}
    }

    public class SettingsClass
    {
        public bool IsOpenOnWeekends {get; set;}
        public string Timezone {get; set;}
        public List<PaymentEnum> SupportedPaymentMethods {get; set;}
    }
}