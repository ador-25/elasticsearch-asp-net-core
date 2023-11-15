
// imports
using ElasticSearch.Services;

// hosts and indexes
string host = "https://localhost:9200";
string indexName = "product-index";


IElasticSearchService service = new ElasticSearchService();

// create index
service.CreateIndex(host, indexName);


// insert data to index
/*Console.WriteLine("FAKE: ");
var data = ProductSeed.SeedProducts();*/