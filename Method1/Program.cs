using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 mathOp = new Class1();//instantiating the class and calling the method
            Console.WriteLine("Passing an integer 19 and adding 82");
            Console.WriteLine(mathOp.Number(19));
            Console.WriteLine("Passing a decimal 1.75 and multiplying by 3"); 
            Console.WriteLine(mathOp.Number(1.75m));
            Console.WriteLine("Passing as 20 as a string");
            Console.WriteLine(mathOp.Number("20"));
            Console.ReadLine();
        }
    }
}
