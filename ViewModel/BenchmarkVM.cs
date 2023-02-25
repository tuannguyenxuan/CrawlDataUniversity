using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.ViewModel
{
    public class BenchmarkVM
    {
        public int Id { get; set; }
        public double? CurrentPoint { get; set; }
        public double? PrePoint { get; set; }
        public int type { get; set; }
        public string[] Blocks { get; set; }
    }
}
