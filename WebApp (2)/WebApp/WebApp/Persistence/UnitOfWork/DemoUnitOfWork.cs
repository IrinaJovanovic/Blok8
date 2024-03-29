﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Unity;
using WebApp.Persistence.Repository;

namespace WebApp.Persistence.UnitOfWork
{
    public class DemoUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
      
        public DemoUnitOfWork(DbContext context)
        {
            _context = context;
        }
        [Dependency]
        public IDiscountRepository Discounts { get; set; }

        [Dependency]
        public IScheduleRepository Schedules { get; set; }

        [Dependency]
        public ILineRepository Lines { get; set; }
       
        [Dependency]
        public IPricelistRepository PriceLists { get; set; }
        [Dependency]
        public IStationRepository Stations { get; set; }
        [Dependency]
        public ITicketRepository Tickets { get; set; }

        [Dependency]
        public IUserRepository Users { get; set; }

        [Dependency]
        public IPayPalRepository PayPals { get; set; }

        [Dependency]
        public IPictureRepository Pictures { get; set; }

       

        [Dependency]
        public IDepatureRepository Depatures { get; set; }

        [Dependency]
        public ILocationRepository Locations { get; set; }





        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}