using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Stanica
    {
        public String Naziv { get; set; }

        public String Adresa { get; set; }

        public int Koordinate { get; set; }

        public List<Linija>linije { get;set;}
    }
}