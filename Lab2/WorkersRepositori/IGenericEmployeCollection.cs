using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2.Models; 
namespace Lab2.WorkersRepositori
{
    interface IGenericEmployeCollection<T>
    {
        public void AddWorker(T Worker);

        public T GetWorker(string LastName);

        public void SaveWorkers();

        public void GetSaveWorkers();

        public List<T> GetAllWorkers();
    }
}
