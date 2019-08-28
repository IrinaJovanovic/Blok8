using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.HelpModels;

namespace WebApp.Persistence.Repository
{
    public interface IUserRepository: IRepository<User,int>
    {

    }
}