using System;
using System.Collections.Generic;
using System.Text;

namespace Method1
{
    class Class1
    { // creating a method with same name but with different types
        public int Number (int addNumber) // creating a method which will be called from the main program
        {
            int total1 = addNumber + 82;
            return total1;

        }
        public int Number (decimal multiplyNumber)
        {
            int total2 = Convert.ToInt32(multiplyNumber) * 3;
            return total2;
        }
        public int Number(string divideNumber) 
        {
            int total2 = Convert.ToInt32(divideNumber); //converting string to integer
            {
                int total3 = Convert.ToInt32(divideNumber) / 2;
                return total3;
            }
        }
    }
}
