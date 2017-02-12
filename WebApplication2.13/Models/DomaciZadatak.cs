using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2._12.Models
{
    public class DomaciZadatak
    {
        public int ID { get; set; }
        public string Fajl { get; set; }
        public virtual Kurs Kursevi { get; set; }
        public virtual Polaznik Polaznici { get; set; }
    }
}