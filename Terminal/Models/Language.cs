using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models
{
   public class Language : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private string languageKG{ get; set; }
        public string LanguageKG{ 
            get=> languageKG; 
            set {
                languageKG = value;
                OnPropertyChanged("LanguageKG");
            } }

        private string languageRU { get; set; }
        public string LanguageRU
        {
            get => languageRU;
            set
            {
                languageRU = value;
                OnPropertyChanged("LanguageRU");
            }
        }

        private string languageEN { get; set; }
        public string LanguageEN
        {
            get => languageEN;
            set
            {
                languageEN = value;
                OnPropertyChanged("LanguageEN");
            }
        }


    }
}
