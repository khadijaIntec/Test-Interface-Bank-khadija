using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Interface_Bank_khadija.Interfaces;
using Test_Interface_Bank_khadija.Models;

namespace Test_Interface_Bank_khadija
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction1 = new Transaction("0001", "30/12/2010", 50);
            Transaction transaction2 = new Transaction("0002", "31/12/2019", 376);
            transaction1.ShowTransaction();
            Console.WriteLine("******************");
            transaction2.ShowTransaction();
            Console.ReadLine();
        }
    }
}
