using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviParcijalniPR3
{
    public class InMemoryDB
    {
        static public int IndeksGeneratorZadnjaCifra { get; set; } = 0;
        static public int IndeksGeneratorSrednjaCifra { get; set; } = 0;
        static public int IndeksGeneratorPrvaCifra { get; set; } = 0;
        static public List<Student> Studenti { get; set; } = new List<Student>();

        public InMemoryDB()
        {
            DodajBuiltInStudente();
        }
        static public void GenerisiCifre()
        {
            ++IndeksGeneratorPrvaCifra;
            if (IndeksGeneratorPrvaCifra > 9)
            {
                IndeksGeneratorPrvaCifra = 0;
                ++IndeksGeneratorSrednjaCifra;
                if (IndeksGeneratorSrednjaCifra > 9)
                {
                    IndeksGeneratorSrednjaCifra = 0;
                    ++IndeksGeneratorZadnjaCifra;
                }
            }
        }
        private void DodajBuiltInStudente()
        {
            GenerisiCifre();
            Studenti.Add(new Student()
            {
                BrojIndeksa = "IB190" + IndeksGeneratorZadnjaCifra.ToString() + IndeksGeneratorSrednjaCifra.ToString() + IndeksGeneratorPrvaCifra.ToString(),
                Ime = "Denis",
                Prezime = "Tojaga",
                Email = "IB19000@edu.fit.ba",
                Slika = null,
                Prosjek = Student.ProsjekStudenta()
            });
            GenerisiCifre();
            Studenti.Add(new Student()
            {
                BrojIndeksa = "IB190" + IndeksGeneratorZadnjaCifra.ToString() + IndeksGeneratorSrednjaCifra.ToString() + IndeksGeneratorPrvaCifra.ToString(),
                Ime = "Halil",
                Prezime = "Focic",
                Email = "IB19001@edu.fit.ba",
                Slika = null,
                Prosjek = Student.ProsjekStudenta()
            });
        }


    }
}
