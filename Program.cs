using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idisposable
{
    class Program
    {
        static void Main(string[] args)
        {
             BaseClass bc = new BaseClass();
            //Console.WriteLine("Enter the Student ID : ");
            //int ID = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Student Name : ");
            //int Name = Convert.ToInt32(Console.ReadLine());
            Program e = new Program();
            bc.Dispose();
            Console.WriteLine("resource cleared and next statement is executed");
            Console.ReadKey();          
            
        }
    }
}
