using System;

namespace IzzyDeal.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public int storeID { get; set; }
        public string dealDescription { get; set; }
        public string posterURL { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int viewNum { get; set; }
        public int subcategoryID { get; set; }
        public string externalURL { get; set; }
        public int priorityNum { get; set; }
    }
}