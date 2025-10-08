using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KowalskiApp.Lib.Models;


namespace KowalskiApp.Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student
            {
                Name = "Kowalski",
                FirstName = "Adam"
            };

            string a;

            Console.WriteLine(student.ToString());


        }
    }
}
