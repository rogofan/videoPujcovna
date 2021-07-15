using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pujcovna
{
    [Serializable()]
    public abstract class Disk
    {
        //vzor otec od kterého pak dědí CD a DVD
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int CenaVypujcky { get; set; }
        public bool Nepristupne { get; set; }

        protected Disk(string nazev, string zanr, int cenaVypujcky, bool nepristupne)
        {
            Nazev = nazev;
            Zanr = zanr;
            CenaVypujcky = cenaVypujcky;
            Nepristupne = nepristupne;
        }
    }

    [Serializable()]
    public class CD : Disk
    {
        //dědí od disk, speciálně pro CD parametr interpre
        public string Interpret { get; set; }
        //konstruktor CD
        public CD(string interpret, string nazev, string zanr, int cenaVypujcky, bool nepristupne = false) : 
            base(nazev, zanr, cenaVypujcky, nepristupne)
        {
            Interpret = interpret;
        }
    }

    [Serializable()]
    public class Dvd : Disk
    {
        //dědí od disk, speciálně pro DVD parametr režisér
        public string Reziser { get; set; }
        //konstruktor DVD
        public Dvd(string reziser, string nazev, string zanr, int cenaVypujcky, bool nepristupne = false) :
            base(nazev, zanr, cenaVypujcky, nepristupne)
        {
            Reziser = reziser;
        }
    }
    
}
