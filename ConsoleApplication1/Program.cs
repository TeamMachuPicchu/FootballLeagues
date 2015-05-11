using Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new FootballData();

            data.Countries.Add(new Country { Name = "Bulgaria" });
            data.SaveChanges();

            Console.WriteLine("Done!");
        }
    }
}
