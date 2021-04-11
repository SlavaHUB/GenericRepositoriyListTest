using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    class Teacher : Worker
    {
        public double PayDay;

        public double AdditionalPayment;

        public double award;

        public Teacher(string inputLastName, DateTime inputDateOfBurn, string inputStatus, double inputPayDay, double inputAdditionalPayment, double inputAward) : base(inputLastName, inputDateOfBurn, inputStatus)
        {
            PayDay = inputPayDay;

            AdditionalPayment = inputAdditionalPayment;

            award = inputAward;
        }
    }
}
