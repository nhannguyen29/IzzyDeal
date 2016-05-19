using System;
using System.Collections.Generic;

namespace IzzyDeal.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Deal> Deals { get; set; }
    }    
}