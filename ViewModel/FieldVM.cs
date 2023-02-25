using CrawlDataUniversity.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.VIewModel
{
    public class FieldVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MajorVM> Majors { get; set; }
    }
}
