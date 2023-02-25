using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlDataUniversity.Data.Entities
{
    public class MajorGroup
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int FieldId { get; set; }
        public List<Major> Major { get; set; }
        public Field Field { get; set; }
    }
}
