using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket
{
    public class Anket
    {
       

        public string name { get; set; }

        public string surname { get; set; }

        public string father_name { get; set; }

        public string country { get; set; }

        public string city { get; set; }

        public string telephone { get; set; }

        public DateTime birthday { get; set; }

        public string gender { get; set; }

        public Anket(string name, string surname, string father_name, string country, string city, string telephone, DateTime birthday, string gender)
        {
            this.name = name;
            this.surname = surname;
            this.father_name = father_name;
            this.country = country;
            this.city = city;
            this.telephone = telephone;
            this.birthday = birthday;
            this.gender = gender;
        }


    }
}
