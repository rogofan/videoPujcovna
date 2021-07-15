using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Pujcovna
{
    public static class Databaze
    {
        public static BindingList<Zakaznik> Zakaznici { get; private set; } = new BindingList<Zakaznik>();
        public static BindingList<Disk> Sklad { get; private set; } = new BindingList<Disk>();

        static Databaze()
        {
            //Zakaznici.Add(new Zakaznik("Pepa", "Novák", "Praha", 1980));
            //Zakaznici.Add(new Zakaznik("Karel", "Vomáčka", "Kladno", 1990));
            //Zakaznici.Add(new Zakaznik("František", "Dobrota", "Blízká Vesnice", 1977));
            //Zakaznik z = new Zakaznik("Tomáš", "Marný", "Praha", 2005);
            //z.Vypujcene.Add(new CD("Ewa Farna", "Best of", "pop", 25));
            //Zakaznici.Add(z);

            //Sklad.Add(new CD("Rammstein", "Rosenrot", "metal", 25));
            //Sklad.Add(new CD("AC/DC", "Black Ice", "rock", 25));
            //Sklad.Add(new CD("Eva a Vašek", "Plná taška Evy a Vaška", "psychedelický hardcore", 25, true));

            //Sklad.Add(new Dvd("George Lucas", "Star Wars", "scifi", 30));
            //Sklad.Add(new Dvd("Steven Spielberg", "Indiana Jones: Dobyvatelé ztracené archy", "dobrodružný", 30));
            //Sklad.Add(new Dvd("Peter Jackson", "Pán prstenů: Společenstvo prstenu", "fantasy", 30));
            //Sklad.Add(new Dvd("Zdeněk Troška", "Kameňák", "existenciální drama", 30, true));

            Deserializuj();
        }

        public static void Vypujcit(object zO, object dO)
        {
            Zakaznik z = (Zakaznik)zO;
            Disk d = (Disk)dO;

            z.Vypujcene.Add(d);
            Sklad.Remove(d);
        }

        public static void Vratit(object zO, object dO)
        {
            Zakaznik z = (Zakaznik)zO;
            Disk d = (Disk)dO;

            Sklad.Add(d);
            z.Vypujcene.Remove(d);
        }
        //uložení pomocí serializace
        public static void Serializuj()
        {
           

            Serializuj(Zakaznici, "zakaznici.bin");
            Serializuj<Disk>(Sklad, "sklad.bin");
        }

        public static void Serializuj<T>(BindingList<T> list, string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(s, list);
            }
        }
        //deserializace ze souboru 
        public static void Deserializuj()
        {
            

            Zakaznici = Deserializuj<Zakaznik>("zakaznici.bin");
            Sklad = Deserializuj<Disk>("sklad.bin");
        }

        public static BindingList<T> Deserializuj<T>(string soubor)
        {
            using (Stream s = File.Open(soubor, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                return (BindingList<T>)bin.Deserialize(s);
            }
        }
    }
}
