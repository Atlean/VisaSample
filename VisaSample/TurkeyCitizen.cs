using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisaSample
{
    internal class TurkeyCitizen
    {
        public long tcidentitynumber { get; set; }
        public string namesurname { get; set; }
        public DateTime birthday { get; set; }
        public DateTime registirationtime { get; set; }

        public TurkeyCitizen()
        {
            registirationtime = DateTime.Now;

        }
        public string takevisa()
        {
            int age = calculateage(birthday);
            if (age >= 18)
                return "You can apply for a visa";
            else
                return "Parental permission required.";
        }

        private int calculateage(DateTime birthday)
        {
            return DateTime.Today.Year - birthday.Year;
        }
    }
}
