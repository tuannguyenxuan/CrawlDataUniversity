using CrawlDataUniversity.Data.Entities;
using CrawlDataUniversity.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.VIewModel
{
    public class UniversityAddressVM
    {
        public int? Id { get; set; }
        public string Website { get; set; }
        public int Rating { get; set; }
        public string Email { get; set; }
        public List<AddressVM> Addresses { get; set; }
    }
}
