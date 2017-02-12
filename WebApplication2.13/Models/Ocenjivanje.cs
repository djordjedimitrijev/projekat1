using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2._12.Models
{
    public class Ocenjivanje
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Sva polja moraju biti popunjena")]
        [Range(1, 3, ErrorMessage = "Unesite ocenu u ispravnom formatu")]
        [Display(Name = "Ocena")]
        public int Ocena { get; set; }

        public virtual Predavac Predavaci { get; set; }
        public virtual Polaznik Polaznici { get; set; }
        public virtual Kurs Kursevi { get; set; }
    }
}
