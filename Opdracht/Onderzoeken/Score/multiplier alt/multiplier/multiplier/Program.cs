using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = 0;
            double winst = 10;
            double multiplier = 1;
            string iets;

            for (int i=0; i < 50 ; i++)
            {
                Console.WriteLine("Goed of Fout");
                iets=Convert.ToString(Console.ReadLine());

                if (iets == "goed")
                {
                    score += multiplier * winst;

                    switch (multiplier)
                    {
                        case 1:
                            multiplier += 1;
                            break;
                        case 2:
                            multiplier += 1;
                            break;
                        case 3:
                            multiplier += 1;
                            break;
                        case 4:
                            multiplier += 1;
                            break;
                        case 5:
                            multiplier += 1;
                            break;
                        case 6:
                            multiplier += 1;
                            break;
                        case 7:
                            multiplier += 1;
                            break;
                        case 8:
                            multiplier += 1;
                            break;
                        case 9:
                            multiplier += 1;
                            break;
                        case 10:
                            multiplier += 1;
                            break;
                        case 11:
                            multiplier += 1;
                            break;
                        case 12:
                            multiplier += 1;
                            break;
                        case 13:
                            multiplier += 1;
                            break;
                        case 14:
                            multiplier += 1;
                            break;
                        case 15:
                            multiplier += 1;
                            break;
                        case 16:
                            multiplier += 1;
                            break;
                        case 17:
                            multiplier += 1;
                            break;
                        case 18:
                            multiplier += 1;
                            break;
                        default:
                            multiplier = 1;
                            break;
                    }
                }
                else if (iets == "fout")
                {
                    if (multiplier <= 1)
                    {
                        multiplier -= 0.1;
                    }
                    else
                    {
                        multiplier = 1;
                    }
                }
                Console.WriteLine("uw score is: " + score);
                Console.ReadLine();
            }
        }
    }
}
