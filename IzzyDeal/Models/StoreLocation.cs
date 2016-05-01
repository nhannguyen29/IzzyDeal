using System;

namespace IzzyDeal.Models
{
    public class StoreLocation
    {
        public int Id { get; set; }
        public int storeId { get; set; }
        public string storeAddress { get; set; }
        public string storeCountry { get; set; }
        public string storeCity { get; set; }
        public string storeState { get; set; }
    }
}