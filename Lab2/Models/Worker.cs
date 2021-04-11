using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    class Worker
    {
        public string LastName { get; set; }

        public DateTime DateOfBurn { get; set; }

        public string status { get; set; }


        public Worker(string inputLastName, DateTime inputDateOfBurn, string inputStatus)
        {
            LastName = inputLastName;

            DateOfBurn = inputDateOfBurn;

            status = inputStatus;
        }
    }
}
