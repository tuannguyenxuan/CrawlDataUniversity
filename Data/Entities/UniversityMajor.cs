using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.Data.Entities
{
    public class UniversityMajor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? UniversityId { get; set; }
        public List<Benchmark> Benchmarks { get; set; }
        public University University { get; set; }
    }
}
