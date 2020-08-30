using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models
{
   public class LanguageService
    {
        //ObservableCollection
        private static ObservableCollection<Language> ObjLanguageList;
        public LanguageService()
        {
            ObjLanguageList = new ObservableCollection<Language>()
            {
                new Language{ LanguageRU="КАССА",LanguageKG="КАССА",LanguageEN="Cashier"},
                new Language{ LanguageRU="ПРИЕМ К ВРАЧУ",LanguageKG="ДАРЫГЕР КАБЫЛДООСУ",LanguageEN=" Appointment to the doctor"},
                new Language{ LanguageRU="ЛАБОРАТОРИЯ (A)",LanguageKG="ЛАБОРАТОРИЯ (А)",LanguageEN="Laboratory (А)"},
                new Language{ LanguageRU="№1 НЕВРОПАТОЛОГ",LanguageKG="№1 НЕВРОПАТОЛОГ",LanguageEN="№1 Nepropotologist"},
                new Language{ LanguageRU="№2 КАРДИОЛОГ",LanguageKG="№2 КАРДИОЛОГ",LanguageEN="№2 Cardiologist"},
                new Language{ LanguageRU="№3 ОФТАЛЬМОЛОГ",LanguageKG="№3 ОФТАЛЬМОЛОГ",LanguageEN="№3 Ophthalmologist"},
                new Language{ LanguageRU="№4 ГЕПАТОЛОГ, ГАСТРОЭНТРОЛОГ",LanguageKG="№4 ГЕПАТОЛОГ, ГАСТРОЭНТРОЛОГ",LanguageEN="№4 Hepatologist, Gastroenterologist"},
                new Language{ LanguageRU="№5 НЕФРОЛОГ",LanguageKG="№5 НЕФРОЛОГ",LanguageEN="№5 Nephrologist"},
                new Language{ LanguageRU="№6 ГЕМАТОЛОГ",LanguageKG="№6 ГЕМАТОЛОГ",LanguageEN="№6 Hematologist"},
                new Language{ LanguageRU="№7 ПЕДИАТР",LanguageKG="№7 ПЕДИАТР",LanguageEN="№7 Pediatrician"},
                new Language{ LanguageRU="№8 ЭНДИКРИНОЛОГ",LanguageKG="№8 ЭНДИКРИНОЛОГ",LanguageEN="№8 Endocrinologist"},
                new Language{ LanguageRU="№9 АЛЛЕРГОЛОГ",LanguageKG="№9 АЛЛЕРГОЛОГ",LanguageEN="№9 Allergist"},
                new Language{ LanguageRU="№10 ЛОР",LanguageKG="№10 ЛОР",LanguageEN="№10 Lore"},
                new Language{ LanguageRU="№11СТОМАТОЛОГ",LanguageKG="№11 СТОМАТОЛОГ",LanguageEN="№11 Dentist"},
                new Language{ LanguageRU="Назад",LanguageKG="Артка",LanguageEN="Back"},
                new Language{ LanguageRU="ЛАБОРАТОРИЯ (Б)",LanguageKG="ЛАБОРАТОРИЯ (Б)",LanguageEN=" Laboratory (B)"},
                new Language{ LanguageRU="Специалисты",LanguageKG="Адистиктер",LanguageEN=" Specialists"}


            };

        }

        public ObservableCollection<Language> GetAll()
        {
            return ObjLanguageList;
        }

    }
}
