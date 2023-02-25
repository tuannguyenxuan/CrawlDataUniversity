using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.Data.Entities
{
    public class Benchmark
    {
        public int Id { get; set; }
        public double? CurrentPoint { get; set; }
        public double? PrePoint { get; set; }
        public Type Type { get; set; }
        public string Blocks { get; set; }
        public int UniversityMajorId { get; set; }
        public UniversityMajor UniversityMajor { get; set; }
    }
}
