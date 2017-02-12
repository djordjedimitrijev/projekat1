using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2._12.Models
{
    public class Korisnik
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Sva polja su obavezna")]
        [MaxLength(50, ErrorMessage = "Maksimalna dužina je 50 karaktera")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Sva polja su obavezna")]
        [MaxLength(50, ErrorMessage = "Maksimalna dužina je 50 karaktera")]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sva polja su obavezna")]
        [MaxLength(50, ErrorMessage = "Maksimalna dužina je 50 karaktera")]
        [Display(Name = "Ime")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Sva polja su obavezna")]
        [MaxLength(50, ErrorMessage = "Maksimalna dužina je 50 karaktera")]
        [Display(Name = "Prezime")]
        public string Prezime { get; set; }
    }

    // public class Administrator : Korisnik
    //{

    //    }

    public class Predavac : Korisnik
    {
        public virtual ICollection<Predavanje> Predavanja { get; set; }
        public virtual ICollection<Literatura> Literatura { get; set; }
        public virtual ICollection<Ocenjivanje> Ocenjivanje { get; set; }

    }

    public class Polaznik : Korisnik
    {
        public virtual ICollection<Nastava> Nastava { get; set; }
        public virtual ICollection<DomaciZadatak> DomaciZadataci { get; set; }
        public virtual ICollection<Ocenjivanje> Ocenjivanje { get; set; }
        //public virtual ICollection<Nastava> Nastava { get; set; }
    }
}