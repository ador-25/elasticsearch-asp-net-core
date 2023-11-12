using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearch.Services
{
    public interface IElasticSearchService
    {
        public void Test();
        public void CreateIndex(string url, string indexName);
    }
}
