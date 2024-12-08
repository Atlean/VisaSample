using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaSample
{
    internal class human
    {
        public  string NameSurname { get; set; }
        public bool aliveornot { get; set; }

        public human() //construction ctor.
        {
            aliveornot =true;
        }

        public human(string NameSurname)
        {
            NameSurname = NameSurname;
            aliveornot=true;
        }

        public static string Hello() //Proje başlangıcında Merhaba yazılacak. Tüm her yerden erişilebilir olsun diye static açılır.
        {
            return "Hello";
        }

        public string NameAnnounce()
        {
            return "My name is " + NameSurname;
        }

    }
}
