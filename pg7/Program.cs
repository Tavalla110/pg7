using System;

namespace pg7
{
    class Program
    {
        public static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int a = Convert.ToInt32(str1);
            int b = Convert.ToInt32(str2);
            int gcd = GCD(a, b);
            int lcm = LCM(a, b);
            Console.WriteLine(gcd+" :BMM  "+lcm+"  :KMM");
        }

        private static int GCD(int a, int b)
        {
            int gcd = 0;
            if (a == 0 || b == 0)
            {
                gcd = 0;
            }
            else
            {
                if (a > b)
                {
                    for (int i = b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            gcd = i;
                            break;
                        }

                    }
                }
                else if (a < b)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            gcd = i;
                            break;
                        }
                    }
                }
                else
                {
                    gcd = a;
                }
            }
            return gcd;
        }

        public static int LCM(int a, int b)
        {
            int lcm = 0;
            if (a == 0 || b == 0)
            {
                lcm = 0;
            }
            else
            {
                if (a == b)
                {
                    lcm = a;
                }
                else if (a < b)
                {
                    if (b % a == 0)
                    {
                        lcm = b;
                    }
                    else
                    {
                        int factor = 2;
                        bool foundlcm = false;
                        while (!foundlcm)
                        {
                            int multiple = factor * b;
                            if (multiple % a == 0)
                            {
                                lcm = multiple;
                                foundlcm = true;
                            }
                            factor++;
                        }
                    }
                }
                else if (a > b)
                {
                    if (a % b == 0)
                    {
                        lcm = a;
                    }
                    else
                    {
                        int factor = 2;

                        bool foundlcm = false;
                        while (!foundlcm)
                        {
                            int multiple = factor * a;
                            if (multiple % b == 0)
                            {
                                lcm = multiple;
                                foundlcm = true;
                            }
                            factor++;
                        }
                    }
                }

            }
            return lcm;
        }
    }
}
