using System;

namespace IzzyDeal.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string DealDescription { get; set; }
        public string PosterUrl { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ViewNum { get; set; }
        public int CategoryId { get; set; }
        public string ExternalUrl { get; set; }
        public int PriorityNum { get; set; }
    }
}