using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Persistence.Repository;

namespace WebApp.Persistence.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
         int Complete();
     
        ILineRepository Lines { get; set; }
        
        IPricelistRepository PriceLists { get; set; }
        IStationRepository Stations { get; set; }
        ITicketRepository Tickets { get; set; }
        IScheduleRepository Schedules { get; set; }
        IDiscountRepository Discounts { get; set; }
        IPayPalRepository PayPals { get; set; }
        IUserRepository Users { get; set; }
        IPictureRepository Pictures { get; set; }
        IDepatureRepository Depatures { get; set; }
        ILocationRepository Locations { get; set; }
        // int Complete();
    }
}
