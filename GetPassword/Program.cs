using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPassword
{
    internal class Program

    {
        static Random random = new Random();
        static char[] SpecialSumbol = { '!', '@', '#', '$', '%', '|' };
        static string password = "";





        static string GetNumber()
        {

            return Convert.ToString(random.Next(0, 10));
        }
        static char GetLowerLetters()
        {
            /* 97-123 */

            return (char)random.Next(97, 123);
        }
        static char GetUpperLetters()
        {
            /* 65-91 */

            return (char)random.Next(65, 91);
        }


        static char GetSpecialSymbol()
        {
            return SpecialSumbol[random.Next(0, SpecialSumbol.Length)];

        }

        static string GetPasswordNew(int lenpassword = 16, int? mincountnumber = null, int? mincountletter = null, bool chekuperletters = false, bool chekspecsymbol = false)
        {
            try
            {
                int[] indxnumbers = new int[lenpassword];
                int[] indxletters = new int[lenpassword];
                int[] randinletters = new int[Convert.ToInt32(mincountletter)];
                if ((mincountnumber != null & mincountnumber != 0) | (mincountletter != null & mincountletter != 0))
                {

                    for (int i = 0; i < indxnumbers.Length; i++)
                    {
                        indxnumbers[i] = i;
                        indxletters[i] = i;
                    }
                    if (mincountletter != null & mincountletter != 0 & (mincountnumber == null | mincountnumber == 0))
                    {
                        int endinxlettes = indxletters.Length;
                        for (int i = 0; i < randinletters.Length; i++)
                        {
                            var x = random.Next(0, endinxlettes);
                            randinletters[i] = indxletters[x];
                            indxletters[x] = indxletters[endinxlettes - 1];
                            indxletters[endinxlettes - 1] = lenpassword + 1;
                            endinxlettes--;

                        }
                        var z = 1;
                        while (z == 1)
                        {
                            z = 0;
                            for (int i = 0; i < randinletters.Length - 1; i++)
                            {
                                if (randinletters[i] > randinletters[i + 1])
                                {
                                    var g = randinletters[i];
                                    randinletters[i] = randinletters[i + 1];
                                    randinletters[i + 1] = g;
                                    z = 1;
                                }
                            }
                        }
                    }

                }


                while (password.Length < lenpassword)
                {
                    var randsymbo = random.Next(0, 4);

                    if (randsymbo == 0 & mincountnumber == null)
                    {
                        password = password + GetNumber();

                    }

                    if (randsymbo == 1 & mincountletter == null)
                    {
                        password = password + GetLowerLetters();

                    }
                    if (randsymbo == 2 & chekuperletters & mincountletter == null)
                    {
                        password = password + GetUpperLetters();

                    }
                    if (randsymbo == 3 & chekspecsymbol)
                    {
                        password = password + GetSpecialSymbol();


                    }
                    if (chekspecsymbol == false & mincountletter != null & mincountletter != 0 & mincountnumber != null & mincountnumber != 0)
                    {

                        break;

                    }


                }


                if (chekspecsymbol == false & mincountnumber != 0 & mincountnumber != null & mincountletter != null & mincountletter != 0)
                {
                    for (int i = 0; i < lenpassword; i++)
                    {
                        password = password + "*";

                    }



                }

                var confpassword = password.ToCharArray();



                if (mincountnumber != 0 & mincountnumber != null)

                {

                    int countnumbers = 0;
                    int randin;
                    int lengsnumber = lenpassword;
                    while (-1 * countnumbers < mincountnumber)
                    {
                        randin = random.Next(0, lenpassword + countnumbers);
                        confpassword[indxnumbers[randin]] = Convert.ToChar(GetNumber());
                        indxnumbers[randin] = indxnumbers[lengsnumber - 1];
                        indxnumbers[lengsnumber - 1] = lenpassword + 1;
                        lengsnumber--;
                        countnumbers--;



                    }

                    if (mincountletter != null & mincountletter != 0)
                    {
                        int[] indlet = new int[lenpassword - Convert.ToInt32(mincountnumber)];

                        var c = 0;
                        for (int i = 0; i < confpassword.Length; i++)
                        {
                            if (int.TryParse(Convert.ToString(confpassword[i]), out int res) == false)
                            {
                                indlet[c] = i;
                                c++;
                            }

                        }

                        int n = indlet.Length;
                        int countlettes = 0;
                        while (countlettes < mincountletter)
                        {
                            int a = random.Next(0, n);
                            int f = random.Next(0, 2);
                            if (chekuperletters)
                            {
                                confpassword[indlet[a]] = f == 0 ? GetLowerLetters() : GetUpperLetters();
                                var h = indlet[a];
                                indlet[a] = indlet[n - 1];
                                indlet[n - 1] = h;
                                n = n - 1;
                                countlettes = countlettes + 1;




                            }
                            else
                            {
                                confpassword[indlet[a]] = GetLowerLetters();
                                var h = indlet[a];
                                indlet[a] = indlet[n - 1];
                                indlet[n - 1] = h;
                                n = n - 1;
                                countlettes = countlettes + 1;



                            }


                        }





                    }


                }
                else
                {
                    for (int i = 0; i < randinletters.Length; i++)
                    {
                        int d = random.Next(0, 2);
                        if (chekuperletters)
                        {
                            if (d == 0)
                            {
                                confpassword[randinletters[i]] = GetLowerLetters();


                            }
                            else
                            {
                                confpassword[randinletters[i]] = GetUpperLetters();
                            }

                        }
                        else
                        {

                            confpassword[randinletters[i]] = GetLowerLetters();
                        }




                    }


                }






                password = new string(confpassword);
                return password;
            }
            catch
            {
                return "Неверные параметры";
            }
        }
        





        static void Main(string[] args)
        {
            int lenpassword=16;
            int? countnumber=null;
            int? countletter=null;
            bool chekuperletter=false;
            bool chekspecsymbol=false;
            int help = 0;
            int help1 = 0;
            int help2 = 0;
            int help3 = 0;
            int help4 = 0;
            int help5 = 0;
           foreach(string value in args)
            {
               
                if(int.TryParse(value,out int res)|value.Substring(0,value.IndexOf("=")+1)== "--length=")
                {
                   
                    lenpassword = int.TryParse(value, out int result) == true ? Convert.ToInt32(value) : Convert.ToInt32(value.Substring(value.IndexOf("=")+1));
                    help = 1;
                    
                }
                if (value.Substring(0, value.IndexOf("=") + 1) == "--digits=")
                {
                    
                    countnumber=  Convert.ToInt32(value.Substring(value.IndexOf("=") + 1));
                    help1 = 1;
                    
                }
                if (value.Substring(0, value.IndexOf("=") + 1) == "--letters=")
                {

                    countletter=  Convert.ToInt32(value.Substring(value.IndexOf("=") + 1));
                    help2 = 1;
                    
                }
                if (value== "--uppercase" | value=="-u")
                {

                    chekuperletter = true;
                    help3= 1;
                }
                if(value== "--special" | value == "-s")
                {
                    
                    chekspecsymbol= true;
                    help4= 1;
                }
                if (value == "-us" | value == "-su")
                {
                    chekspecsymbol= true;
                    chekuperletter= true;
                    help5= 1;
                }
                
            }
            if (help + help1 + help2+help3+help4+help5 == args.Length)
            {

                if (help == 1 & help1 == 1 & help2 == 1 & Convert.ToInt32(countletter) + Convert.ToInt32(countnumber) < lenpassword & chekspecsymbol == false)
                {

                    Console.WriteLine("Неверные параметры");
                }
                else
                {
                    if (help == 0 & (help1 == 1 | help2 == 1))
                    {

                        lenpassword = Convert.ToInt32(countletter) + Convert.ToInt32(countnumber);
                    }
                    Console.WriteLine(GetPasswordNew(lenpassword, countnumber, countletter, chekuperletter, chekspecsymbol));

                }
            }
            else
            {
                Console.WriteLine("Неверные параметры");
            }
        }
    }
}
