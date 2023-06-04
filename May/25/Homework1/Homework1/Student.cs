using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Student
    {
        private string name, surname, email = null;

        public string Name
        {
            set
            {
                name = value;
                if (surname != null)
                {
                    email = $"{name}.{surname}@gmail.com";
                }
            }

            get
            {
                return name;
            }
        }

        public string Surname
        {
            set
            {
                surname = value;
                if (name != null)
                {
                    email = $"{name}.{surname}@gmail.com";
                }
            }

            get
            {
                return surname;
            }
        }
    }
}
