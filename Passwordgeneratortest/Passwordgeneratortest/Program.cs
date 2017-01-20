using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Passwordgenerator;

namespace Passwordgeneratortest
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int dig = int.Parse(Console.ReadLine());
            //length is the length of the password 
            //if the dig = 1, then  generated password consisting of numbers
            //if the dig = 2, then password generated only of the symbols
            //if the dig = 3, then  generated password consisting of letters
            // if the dig = 4 , password is made up of symbols, letters and numbers.

            Console.WriteLine(Passwordgen.NewPindigits(length, dig));
        }
    }
}
