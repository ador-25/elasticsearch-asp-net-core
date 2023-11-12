using Bogus;
using ElasticSearch.Models;

public class ProductSeed
{
    public static List<Product> SeedProducts()
    {
        var faker = new Faker();  // Make sure to import the Bogus namespace

        var products = new List<Product>();

        for (int i = 1; i <= 50; i++)
        {
            var product = new Product
            {
                Id = i,
                Name = faker.Commerce.ProductName(),
                Description = faker.Lorem.Paragraphs(faker.Random.Number(3, 5))
            };

            products.Add(product);
            Console.WriteLine("######################################");
            Console.WriteLine($"{product.Id}");
            Console.WriteLine($"{product.Name}");
            Console.WriteLine($"{product.Description}");
        }

        return products;
    }
}

