using CrawlDataUniversity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.VIewModel
{
    public class UniversityVM
    {
        public int Id { get; set; }
        public string UniName { get; set; }
        public string UniCode { get; set; }
        public string UniImage { get; set; }
        public List<UniversityMajorVM> Majors { get; set; }
    }
}
