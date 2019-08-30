using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Web;
using WebApp.Models;


namespace WebApp.Persistence.Repository
{
    public class TicketRepository : Repository<Ticket, int>, ITicketRepository
    {
       // protected ApplicationDbContext Context { get { return context as ApplicationDbContext; } }
        public TicketRepository(DbContext context) : base(context)
        {
        }



    }
}