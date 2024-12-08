using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaSample
{
    internal class USACitizen //Citizens who will go to America do not have to worry about a visa, so we will only show their age.
    {
        public  string NameSurname { get; set; }
        public DateTime birthday { get; set; }
        public string Language { get; set; }

        public int age //This is not void. We have to use return.
        {
            get
            {
                return DateTime.Today.Year-birthday.Year;
            }
        }

    }
}
