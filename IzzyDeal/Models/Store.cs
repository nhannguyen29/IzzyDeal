using System;
using System.Collections.Generic;

namespace IzzyDeal.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public ICollection<Deal> Deals { get; set; }
    }
}