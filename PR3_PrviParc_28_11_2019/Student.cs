using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviParcijalniPR3
{
    public class Student
    {
        public int PredmetGenerator { get; set; } = 0;

        public Random randomOcjena = new Random();
        public int IndekserPredmeta { get; set; } = 0;
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public double Prosjek { get; set; }
        public Image Slika { get; set; }
        public int BrojPolozenihPredmeta { get; set; }
        static public List<Predmet> Predmeti { get; set; }


        public Student()
        {
            Predmeti = new List<Predmet>();
            GenerisiPredmeteStudentu();
            Prosjek = ProsjekStudenta();
            PrebrojPolozene();
        }

        private void GenerisiPredmeteStudentu()
        {
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(5, 10), NazivPredmeta = "Predmet" + (++PredmetGenerator).ToString(),datumPolaganja=DateTime.Now });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(5, 10), NazivPredmeta = "Predmet" + (++PredmetGenerator).ToString(),datumPolaganja=DateTime.Now });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(5, 10), NazivPredmeta = "Predmet" + (++PredmetGenerator).ToString(),datumPolaganja=DateTime.Now });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(5, 10), NazivPredmeta = "Predmet" + (++PredmetGenerator).ToString(),datumPolaganja=DateTime.Now });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(5, 10), NazivPredmeta = "Predmet" + (++PredmetGenerator).ToString(),datumPolaganja=DateTime.Now });
        }
        private void PrebrojPolozene()
        {
            foreach (var predmet in Predmeti)
                if (predmet.Ocjena > 5)
                    BrojPolozenihPredmeta++;
        }
        static public double ProsjekStudenta()
        {
            double prosjek = 0;
            if (Predmeti.Count == 0)
                return prosjek;
            foreach (var predmet in Predmeti)
                prosjek += predmet.Ocjena;
            return prosjek / Predmeti.Count;
        }
    }
}
