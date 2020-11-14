using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationV2
{
    class Notation
    {
        private String surname;
        private String number;

        public Notation(String surname, String number)
        {
            this.surname = surname;
            this.number = number;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setNumber(String number)
        {
            this.number = number;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getNumber()
        {
            return number;
        }

        public override string ToString()
        {
            return surname + " " + number;
        }
    }
}
