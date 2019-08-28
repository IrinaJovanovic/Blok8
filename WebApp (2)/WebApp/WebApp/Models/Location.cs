using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Location
    {
        public int Id { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}