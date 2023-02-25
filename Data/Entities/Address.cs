using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.Data.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string  Display { get; set; }
        public int? ProvinceId { get; set; }
        public Province Province { get; set; }
        public int? UniversityId { get; set; }
        public University University { get; set; }
        public string District { get; set; }
        public int? Side { get; set; }
    }
}
