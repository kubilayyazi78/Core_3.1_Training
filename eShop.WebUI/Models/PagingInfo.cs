using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Models
{
    public class PagingInfo
    {
        public int PageSize { get; set; }

        public int ItemsCount { get; set; }

        public int TotalPageCount
        {
            get
            {
                return (int)Math.Ceiling((decimal)ItemsCount / PageSize);
            }
        }

        public int CurrentPage { get; set; }

    }
}
