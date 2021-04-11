using System;
using Lab2.Models;
using Lab2.WorkersRepositori;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var IEmploy = new GenericEmployeCollection<Worker>();
            Console.WriteLine("1) Добавить рабочего");
            Console.WriteLine("2) Добавить учителя");
            Console.WriteLine("3) Посмотреть базу записей");
            Console.WriteLine("4) Просмотреть по критерию");
            Console.WriteLine("5) Сохранить всё");

            while (true)
            {
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите фамилию");

                            string LastName = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Введите статус");
                            string Status = Convert.ToString(Console.ReadLine());

                            IEmploy.AddWorker(new Worker(LastName, DateTime.Now, Status));

                            Console.WriteLine("Рабочий успешно добавлен!");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите фамилию");

                            string LastName = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Введите статус");

                            string Status = Convert.ToString(Console.ReadLine());

                            Console.WriteLine("Введите оклад");
                            double PayDay = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Введите доплату за стаж");
                            double AdditionalPayment = Convert.ToDouble(Console.ReadLine());


                            Console.WriteLine("Введите премию");
                            double award = Convert.ToDouble(Console.ReadLine());
                            var tc = new Worker(LastName, DateTime.Now, Status);

                            tc = new Teacher(LastName, DateTime.Now, Status, PayDay, AdditionalPayment, award);
                            IEmploy.AddWorker(tc);

                            Console.WriteLine("Преподаватель успешно добавлен!");
                        }
                        break;
                    case 3:
                        {
                            IEmploy.GetAllWorkers();
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Введите фамилию искомого человека");
                            string LastName = Convert.ToString(Console.ReadLine());

                            IEmploy.GetWorker(LastName);
                        }
                        break;
                    case 5:
                        {
                            IEmploy.SaveWorkers();
                            Console.WriteLine("Сохранение прошло успешно");
                        }
                        break;
                }
            }
            
        }
    }
}
