using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.VIewModel
{
    public class ProvinceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Type { get; set; }
        public string Name_with_type { get; set; }
        public string Code { get; set; }
        public string Domain { get; set; }
    }
}
