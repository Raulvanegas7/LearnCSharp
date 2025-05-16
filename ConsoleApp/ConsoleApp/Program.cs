

using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleApp.DTOs;
using ConsoleApp.Import;
using ConsoleApp.metodo;
using ConsoleApp.Stores;

internal class Program
{

    private static void Main(string[] args)
    {
        JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
        };

        options.Converters.Add(new JsonStringEnumConverter());

        List<ModelStores> stores = JsonSerializer.Deserialize<List<ModelStores>>(StoreClass.StoreDataText, options);

        int nufmeroStore = stores.Count;

        List<ModelStores> tiendas = StoresFilter.ShowStores(stores);

        List<ModelStores> city = StoresFilter.AtChicago(stores);

        List<ModelStores> storeByFecha = StoresFilter.StoreDate(stores);

        List<string> storeOwnerEmail = StoresFilter.findEmails(stores);

        List<StoreDto> storeOwnerInfo = StoresFilter.OwnerInfo(stores);

        var res = 10;
    }

}