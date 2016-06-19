using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace IzzyDeal.Models
{
    public class IzzyDealRepository : IIzzyDealRepository
    {
        private IzzyDealDbContext _context;

        private ILogger<IzzyDealRepository> _logger;

        public IzzyDealRepository(IzzyDealDbContext context, ILogger<IzzyDealRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Deal> GetAllDeal()
        {
            try
            {
                return _context.Deals.OrderBy(t => t.PriorityNum).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not get the deal data from database", ex);
                return null;
            }
             }
    }
}