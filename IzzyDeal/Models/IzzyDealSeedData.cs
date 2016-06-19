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
                var seedStore = new Store()
                {
                    StoreName = "test"
                };

                var seedCategory = new Category()
                {
                    CategoryName = "test"
                };

                var seedDeal = new Deal() 
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
                _context.Stores.Add(seedStore);
                _context.Categories.Add(seedCategory);
                _context.Deals.Add(seedDeal);
                
                _context.SaveChanges();
            }
        } 
    }
}