using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2._12.Models
{
    public class Predavanje
    {

        public int ID { get; set; }

        public virtual Predavac Predavaci { get; set; }
        public virtual Kurs Kursevi { get; set; }
    }
}

