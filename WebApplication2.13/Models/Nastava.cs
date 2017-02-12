using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2._12.Models
{
    public class Nastava

    {
        public int ID { get; set; }

        public virtual Polaznik Polaznici { get; set; }
        public virtual Kurs Kursevi { get; set; }
    }
}
