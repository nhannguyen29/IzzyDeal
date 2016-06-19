using System.Collections.Generic;

namespace IzzyDeal.Models
{
    public interface IIzzyDealRepository
    {
        IEnumerable<Deal> GetAllDeal();
    }
}