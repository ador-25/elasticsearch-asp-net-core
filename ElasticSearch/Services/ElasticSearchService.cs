using ElasticSearch.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearch.Services
{
    public class ElasticSearchService : IElasticSearchService
    {
        public void CreateIndex(string url, string indexName)
        {
            var settings = new ConnectionSettings(new Uri(url))
            .DefaultIndex(indexName);

            var client = new ElasticClient(settings);

            var createIndexResponse = client.Indices.Create("your_index_name", c => c
                .Map<Product>(m => m
                    .AutoMap()
                )
            );

            if (createIndexResponse.IsValid)
            {
                Console.WriteLine("Index created successfully!");
            }
            else
            {
                Console.WriteLine($"Failed to create index: {createIndexResponse.DebugInformation}");
            }
        }

        public void Test()
        {
            Console.WriteLine("Elastic Search Test!");
        }
    }
}
