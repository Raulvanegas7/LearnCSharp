// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleApp.Import;
using ConsoleApp.Products;

Console.WriteLine("Hello, World!");

JsonSerializerOptions options = new()
{
    PropertyNameCaseInsensitive = true,
};

// options.Converters.Add(new JsonStringEnumConverter());

string pro = ProductData.ProductDataText;
Console.WriteLine(pro);

List<Product> products = JsonSerializer.Deserialize<List<Product>>(ProductData.ProductDataText, options);

var count = products.Count;

var isdf = 3;
