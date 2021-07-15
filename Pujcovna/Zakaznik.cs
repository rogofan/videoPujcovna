using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pujcovna
{
    [Serializable()]
    public class Zakaznik : INotifyPropertyChanged
    {
        //deklarace zákazníka
        private string _jmeno;
        private string _prijmeni;
        private string _adresa;
        private int _rok;
        //metody pro přístup
        public string Jmeno
        { get
            {
                return _jmeno;
            }
            set
            {
                if (_jmeno != value)
                {
                    _jmeno = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Prijmeni
        {
            get
            {
                return _prijmeni;
            }
            set
            {
                if (_prijmeni != value)
                {
                    _prijmeni = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Adresa
        {
            get
            {
                return _adresa;
            }
            set
            {
                if (_adresa != value)
                {
                    _adresa = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public int RokNarozeni
        {
            get
            {
                return _rok;
            }
            set
            {
                if (_rok != value)
                {
                    _rok = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Plnolety");
                }
            }
        }
        //ověření plnoletosti
        public bool Plnolety
        {
            get { return (DateTime.Today.Year - _rok) >= 18; }
        }

        public BindingList<Disk> Vypujcene { get; private set; } = new BindingList<Disk>();

        //konstruktor zakznik
        public Zakaznik(string jmeno, string prijmeni, string adresa, int rokNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
            RokNarozeni = rokNarozeni;
        }
        //metoda pro nahrazení proměné v případě změny
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //vyvolá se při změně hodnoty tam kde je využit
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
