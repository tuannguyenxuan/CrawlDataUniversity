using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.ViewModel
{
    public class AddressVM
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Display { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public int? Side { get; set; }
    }
}
