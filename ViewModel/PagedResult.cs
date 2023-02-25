
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlDataUniversity.VIewModel
{
    public class PagedResult<T> 
    {
        int Count;
        public List<T> universities { set; get; }
    }
}
