using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Linija
    {
        [Key]

        public int Rbr { get; set; }

       // List<Stanica> stanice = new List<Stanica>();
        public List<Stanica> stanice {get;set;}
    }
}