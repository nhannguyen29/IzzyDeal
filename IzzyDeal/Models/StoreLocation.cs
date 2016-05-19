using System;

namespace IzzyDeal.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string StoreAddress { get; set; }
        public string StoreCountry { get; set; }
        public string StoreCity { get; set; }
        public string StoreState { get; set; }
    }
}