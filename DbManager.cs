using Simple.NET.DataBase;
using Simple.NET.DataBase.Models;

namespace Simple.NET
{
    public class DbManager : IDisposable
    {
        private const string HorizontalLine = "======================================";
        private OrdersDB _database = new OrdersDB();

        public void PopulateTasks()
        {
            Console.WriteLine(HorizontalLine);
            Console.WriteLine("Please populate [Tasks] table:");
            InsertTask();
            Console.WriteLine("Populating [Tasks] table finished.");
            Console.WriteLine(HorizontalLine);
            
        }

        public void InsertTask()
        {
            Console.WriteLine("Please populate [Tasks] row:");
            Console.WriteLine("Please write data in [Name] way:");
            var task = new Tasks();
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Populating [Tasks] row finished.");
            }
            else
            {
                task.Name = name;
                _database.Tasks.Add(task);
                InsertTask();
            }
        }

        public void Dispose() { }
    }
}
