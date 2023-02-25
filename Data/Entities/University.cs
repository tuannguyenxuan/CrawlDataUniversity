using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.Data.Entities
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ImagePath { get; set; }
        public string Website { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Facebook { get; set; }
        public List<Address> Addresses { get; set; }
        public List<UniversityMajor> UniversityMajors { get; set; }
    }
}
