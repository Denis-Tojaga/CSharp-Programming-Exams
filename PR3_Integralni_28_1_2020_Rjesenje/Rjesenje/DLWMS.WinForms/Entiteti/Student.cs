using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public int GodinaStudija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }     
        public bool Aktivan { get; set; }
        public virtual Spol Spol { get; set; }
        public virtual List<StudentiPredmeti> PolozeniPredmeti { get; set; }
        public virtual ICollection<Uloga> Uloge { get; set; }
        public virtual List<StudentiPotvrde> Potvrde { get; set; } = new List<StudentiPotvrde>();
        public Student()
        {
            PolozeniPredmeti = new List<StudentiPredmeti>();
            Uloge = new HashSet<Uloga>();
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }


        public float ProsjekStudenta()
        {
            float prosjek = 0;
            if (PolozeniPredmeti.Count() == 0)
                return prosjek;
            else
                foreach (var predmet in PolozeniPredmeti)
                    prosjek += predmet.Ocjena;

            return prosjek / PolozeniPredmeti.Count();
        }
    }
}
