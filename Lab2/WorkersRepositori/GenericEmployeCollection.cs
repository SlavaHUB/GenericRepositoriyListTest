using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Lab2.Models;


namespace Lab2.WorkersRepositori
{
    class GenericEmployeCollection<T> : IGenericEmployeCollection<T>
    {   
        private Queue<T> Workers = new Queue<T>();

        public void AddWorker(T Worker)
        {
            Workers.Enqueue(Worker);
        }
        
        public T GetWorker(string LastName)
        {
            return Workers.Peek();
        }

        public void SaveWorkers()
        {
            foreach (var worker in Workers)
            {
                using (StreamWriter sw = new StreamWriter("DataBase.txt", true, System.Text.Encoding.Default))
                {
                    try
                    {
                        if (worker is Teacher)
                        {
                            Teacher tc = (Teacher)(object)worker;

                            sw.WriteLine(tc.LastName + " " + tc.DateOfBurn + " " + tc.status + " " + tc.PayDay + " " + tc.AdditionalPayment + " " + tc.award);
                        }
                        else
                        {
                            Worker wr = (Worker)(object)worker;

                            sw.WriteLine(wr.LastName + " " +wr.DateOfBurn + " " + wr.status);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public void GetSaveWorkers()
        {
            
        }

        public List<T> GetAllWorkers()
        {
            Regex reg = new Regex(pattern);
            return null;
        }
    }
}
