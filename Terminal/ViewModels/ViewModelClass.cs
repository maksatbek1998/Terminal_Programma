using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Terminal.Commands;
using Terminal.Folder_Class;
using Terminal.Models;

namespace Terminal.ViewModels
{
    class ViewModelClass : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private  void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        LanguageService ObjLanguageService;
        public ViewModelClass()
        {
            ObjLanguageService = new LanguageService();
            LoadData();
            CurrentLanguage = new Language();
            Dysplay();
         }

        private ObservableCollection<Language> languageList;
        public ObservableCollection<Language> LanguageList
        {
            get { return languageList; }
            set
            {
                languageList = value;
                OnPropertyChanged("LanguageList");
            }
        }

        private Language currentLanguage;
        public Language CurrentLanguage
        {
            get { return currentLanguage; }
            set
            {
                currentLanguage = value;
                OnPropertyChanged("CurrentEmployee");
            }
        }
        private void LoadData()
        {
            LanguageList = new ObservableCollection<Language>(ObjLanguageService.GetAll());
        }

        #region Переменные Языка

        private string specialists { get; set; }
        public string Specialists
        {
            get { return specialists; }
            set
            {
                specialists = value;
                OnPropertyChanged("Specialists");
            }
        }
        private  string cashier { get; set; }
        public  string Cashier
        {
            get { return cashier; }
            set
            {
                cashier = value;
                OnPropertyChanged("Cashier");
            }
        }

        private string laboratory { get; set; }
        public string Laboratory
        {
            get { return laboratory; }
            set
            {
                laboratory = value;
                OnPropertyChanged("Laboratory");
            }
        }

        private string appointment { get; set; }
        public string Appointment
        {
            get { return appointment; }
            set
            {
                appointment = value;
                OnPropertyChanged("Appointment");
            }
        }
        private string nepropotologist { get; set; }
        public string Nepropotologist
        {
            get { return nepropotologist; }
            set
            {
                nepropotologist = value;
                OnPropertyChanged("Nepropotologist");
            }
        }

        private string cardiologist { get; set; }
        public string Cardiologist
        {
            get { return cardiologist; }
            set
            {
                cardiologist = value;
                OnPropertyChanged("Cardiologist");
            }
        }

        private string ophthalmologist { get; set; }
        public string Ophthalmologist
        {
            get { return ophthalmologist; }
            set
            {
                ophthalmologist = value;
                OnPropertyChanged("Ophthalmologist");
            }
        }

        private string gastroenterologist { get; set; }
        public string Gastroenterologist
        {
            get { return gastroenterologist; }
            set
            {
                gastroenterologist = value;
                OnPropertyChanged("Gastroenterologist");
            }
        }
        private string nephrologist { get; set; }
        public string Nephrologist
        {
            get { return nephrologist; }
            set
            {
                nephrologist = value;
                OnPropertyChanged("Nephrologist");
            }
        }

        private string hematologist { get; set; }
        public string Hematologist
        {
            get { return hematologist; }
            set
            {
                hematologist = value;
                OnPropertyChanged("Hematologist");
            }
        }
        private string pediatrician { get; set; }
        public string Pediatrician
        {
            get { return pediatrician; }
            set
            {
                pediatrician = value;
                OnPropertyChanged("Pediatrician");
            }
        }
        private string endocrinologist { get; set; }
        public string Endocrinologist
        {
            get { return endocrinologist; }
            set
            {
                endocrinologist = value;
                OnPropertyChanged("Endocrinologist");
            }
        }
        private string allergist { get; set; }
        public string Allergist
        {
            get { return allergist; }
            set
            {
                allergist = value;
                OnPropertyChanged("Allergist");
            }
        }
        private string lore { get; set; }
        public string Lore
        {
            get { return lore; }
            set
            {
                lore = value;
                OnPropertyChanged("Lore");
            }
        }
        private string dentist { get; set; }
        public string Back
        {
            get { return dentist; }
            set
            {
                dentist = value;
                OnPropertyChanged("Back");
            }
        }

        private string back { get; set; }
        public string Dentist
        {
            get { return back; }
            set
            {
                back = value;
                OnPropertyChanged("Dentist");
            }
        }

        private string labB { get; set; }
        public string LabB
        {
            get { return labB; }
            set
            {
                labB = value;
                OnPropertyChanged("LabB");
            }
        }


       
        
        public ICommand ToKG => new RelayCommand((obj) => 
        {
            StaticClass.Flag = "KG"; 
             Cashier = LanguageList[0].LanguageKG;
             Appointment = LanguageList[1].LanguageKG;
             Laboratory = LanguageList[2].LanguageKG;
             Nepropotologist = LanguageList[3].LanguageKG;
             Cardiologist = LanguageList[4].LanguageKG;
             Ophthalmologist = LanguageList[5].LanguageKG;
             Gastroenterologist = LanguageList[6].LanguageKG;
             Nephrologist = LanguageList[7].LanguageKG;
             Hematologist = LanguageList[8].LanguageKG;
             Pediatrician = LanguageList[9].LanguageKG;
             Endocrinologist = LanguageList[10].LanguageKG;
             Allergist = LanguageList[11].LanguageKG;
             Lore = LanguageList[12].LanguageKG;
             Dentist = LanguageList[13].LanguageKG;
            Back = languageList[14].LanguageKG;
            LabB= languageList[15].LanguageKG;
            Specialists = languageList[16].LanguageKG;
        });

        public ICommand ToRU => new RelayCommand((obj) =>
        {
            StaticClass.Flag = "RU";
            Cashier = LanguageList[0].LanguageRU;
            Appointment = LanguageList[1].LanguageRU;
            Laboratory = LanguageList[2].LanguageRU;
            Nepropotologist = LanguageList[3].LanguageRU;
            Cardiologist = LanguageList[4].LanguageRU;
            Ophthalmologist = LanguageList[5].LanguageRU;
            Gastroenterologist = LanguageList[6].LanguageRU;
            Nephrologist = LanguageList[7].LanguageRU;
            Hematologist = LanguageList[8].LanguageRU;
            Pediatrician = LanguageList[9].LanguageRU;
            Endocrinologist = LanguageList[10].LanguageRU;
            Allergist = LanguageList[11].LanguageRU;
            Lore = LanguageList[12].LanguageRU;
            Dentist = LanguageList[13].LanguageRU;
            Back = languageList[14].LanguageRU;
            LabB = languageList[15].LanguageRU;
            Specialists = languageList[16].LanguageRU;

        });

        public ICommand ToEN => new RelayCommand((obj) =>
        {
            StaticClass.Flag = "EN";
            Cashier = LanguageList[0].LanguageEN;
            Appointment = LanguageList[1].LanguageEN;
            Laboratory = LanguageList[2].LanguageEN;
            Nepropotologist = LanguageList[3].LanguageEN;
            Cardiologist = LanguageList[4].LanguageEN;
            Ophthalmologist = LanguageList[5].LanguageEN;
            Gastroenterologist = LanguageList[6].LanguageEN;
            Nephrologist = LanguageList[7].LanguageEN;
            Hematologist = LanguageList[8].LanguageEN;
            Pediatrician = LanguageList[9].LanguageEN;
            Endocrinologist = LanguageList[10].LanguageEN;
            Allergist = LanguageList[11].LanguageEN;
            Lore = LanguageList[12].LanguageEN;
            Dentist = LanguageList[13].LanguageEN;
            Back = languageList[14].LanguageEN;
            LabB = languageList[15].LanguageEN;
            Specialists= languageList[16].LanguageEN;

        });

        private void Dysplay()
        {
            if(StaticClass.Flag=="EN")
            ToEN.Execute(null);
            if (StaticClass.Flag == "KG")
                ToKG .Execute(null);
            if (StaticClass.Flag == "RU")
                ToRU.Execute(null);
            
        }
        #endregion

    }
}
