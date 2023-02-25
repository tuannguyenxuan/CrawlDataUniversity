using CrawlDataUniversity.Data.Entities;
using CrawlDataUniversity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.VIewModel
{
    public class UniversityMajorVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<BenchmarkVM> Benchmarks { get; set; }
    }
}
