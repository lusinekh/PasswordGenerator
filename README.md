# PasswordGenerator

<img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="150px" height="150px" /> 



   With this program you can create your own password, it consists of NewPindigits function,  that receives a 2 parametrs,
 1 parameter means we can choose the length of the password we want to generate, through  2 parameter we can choose what l.



   


```c#

    
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
            // if the dig = 4 , password is made up of symbols, letters and //numbers.

            Console.WriteLine(Passwordgen.NewPindigits(length, dig));
        }
    }
}



```
