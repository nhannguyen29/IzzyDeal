using System;
using System.Linq;

namespace IzzyDeal.Models
{
    public class IzzyDealSeedData
    {
        public IzzyDealDbContext _context;
        
        public IzzyDealSeedData(IzzyDealDbContext context)
        {
            _context = context;
        }
        
        public void EnsureSeedData()
        {
            if (!_context.Deals.Any())
            {
                
                var testDeal = new Deal() 
                {
                    StoreId = 1,
                    DealDescription = "Test",
                    PosterURL = "Test",
                    StartTime = DateTime.UtcNow,
                    EndTime = DateTime.UtcNow,
                    ViewNum = 0,
                    CategoryId = 1,
                    ExternalURL = "Test",
                    PriorityNum = 1
                };
                
                _context.Deals.Add(testDeal);
                
                _context.SaveChanges();
            }
        } 
    }
}