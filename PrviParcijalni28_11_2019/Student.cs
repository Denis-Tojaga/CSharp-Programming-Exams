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
        public Random randomOcjena = new Random();
        public int IndekserPredmeta { get; set; } = 0;
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public double Prosjek { get; set; }
        public Image Slika { get; set; }
        static public List<Predmet> Predmeti { get; set; }


        public Student()
        {
            Predmeti = new List<Predmet>();
            GenerisiPredmeteStudentu();
        }

        private void GenerisiPredmeteStudentu()
        {
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(6, 10) });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(6, 10) });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(6, 10) });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(6, 10) });
            Predmeti.Add(new Predmet() { Ocjena = randomOcjena.Next(6, 10) });
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
