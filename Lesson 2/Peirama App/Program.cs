using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_2;
using Lesson_2.Models;

namespace Peirama_App
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            Console.WriteLine(db.Employees.);

        }
    }
}
