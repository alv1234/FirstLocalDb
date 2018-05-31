using FirstLocalDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 db = new Class1();
            Console.WriteLine("Hello");
            Console.WriteLine("Running new query");
            foreach (var item in db.QueryAll())
            {
                Console.WriteLine(String.Format("{0}-{1}-{2}",item.CustomerName,item.CustomerContact,item.Phone));
            }
            Console.WriteLine("Query finished.....");
            Console.WriteLine("Inserting new data");
            db.Add("new Customer", "new Contact", "000-000-2323");
            Console.WriteLine("new entry added");         
            foreach (var item in db.QueryAll())
            {
                Console.WriteLine(String.Format("{0}-{1}-{2}", item.CustomerName, item.CustomerContact, item.Phone));
            }
            Console.WriteLine("Query finished.....");
            Console.ReadLine();


        }
    }
}
