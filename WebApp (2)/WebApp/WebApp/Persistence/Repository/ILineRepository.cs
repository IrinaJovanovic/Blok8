﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Persistence.Repository
{
    public interface ILineRepository : IRepository<Line,int>
    {
        IEnumerable<Line> GetAllLiWithSstations();
        string ReplaceStations(int lineId, IEnumerable<Station> stations);
        void Delete(int id);
    }
}