using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2._12.Models
{
    public class Kurs
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Sva polja su obavezna")]
        [MaxLength(100)]
        [Display(Name = "Naziv kursa")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Sva polja su obavezna")]
        [Range(2015, 2100, ErrorMessage = "Unesite godinu u ispravnom formatu")]
        [Display(Name = "Godina odrzavanja")]
        public int Godina { get; set; }

        public virtual ICollection<Nastava> Nastava { get; set; }
        public virtual ICollection<DomaciZadatak> DomaciZadataci { get; set; }
        public virtual ICollection<Ocenjivanje> Ocenjivanje { get; set; }
        public virtual ICollection<Predavanje> Predavanja { get; set; }
        public virtual ICollection<Literatura> Literatura { get; set; }

    }
}