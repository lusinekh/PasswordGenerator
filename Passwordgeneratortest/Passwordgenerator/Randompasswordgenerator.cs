using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Passwordgenerator
{
    public static class Passwordgen
    {



        public static string NewPindigits(int length, int dig)
        {

            using (var rng = new RNGCryptoServiceProvider())
            {
                var data = new byte[length];
                rng.GetBytes(data);
                var seed = BitConverter.ToInt32(data, 0);

                var rand = new Random(seed);

                Random rnd = new Random();

                string password = String.Empty;




                if (dig > 5 || dig < 1)
                {




                    password = "incorrect enter:  dig";
                    return password;
                }

                else


                    if (dig == 1)
                    {
                        for (int j = 0; j < length; j++)
                        {



                            password += (char)rand.Next(97, 122);



                        }
                    }
                    else

                        if (dig == 2)
                        {
                            {
                                for (int j = 0; j < length; j++)
                                {



                                    password += (char)rand.Next(48, 57);



                                }
                            }
                        }




                        else

                            if (dig == 3)
                            {
                                {
                                    for (int j = 0; j < length; j++)
                                    {



                                        password += (char)rand.Next(65, 90);



                                    }
                                }
                            }



                            else



                                if (dig == 4)
                                {
                                    {


                                        for (int j = 0; j < length; j++)
                                        {

                                            if (rnd.Next(1, 5) == 1)
                                                password += (char)rnd.Next(65, 90);

                                            else if (rnd.Next(1, 5) == 2)
                                                password += (char)rnd.Next(48, 57);
                                            else
                                                if (rnd.Next(1, 5) == 3)
                                                    password += (char)rnd.Next(48, 57);
                                                else
                                                    if (rnd.Next(1, 5) == 4)
                                                        password += (char)rnd.Next(97, 122);




                                        }
                                    }
                                }



                return password;
            }
        }


    }
}









