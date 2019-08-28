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
        IDayTypeRepository DayTypes { get; set; }
        ILineRepository Lines { get; set; }
        IPassengerTypeRepository PassengerTypes { get; set; }
        IPricelistRepository PriceLists { get; set; }
        IStationRepository Stations { get; set; }
        ITicketRepository Tickets { get; set; }
        ITicketPricesRepository TicketPrices { get; set; }
        ITicketTypeRepository TicketTypes { get; set; }
        ITimetableRepository Timetables { get; set; }
        IVehicleRepository Vehicles { get; set; }
        ISerialNumberSLRepository SerialNumberSLs { get; set; }
        IPayPalRepository PayPals { get; set; }
        IUserRepository Users { get; set; }
        IPictureRepository Pictures { get; set; }

       // int Complete();
    }
}
