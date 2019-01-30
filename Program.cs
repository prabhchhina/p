using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, exit = 0;


            while (true)
            {

                Console.Write("Enter Choice : \n");
                Console.Write("1. kilometers and miles\n");
                Console.Write("2. miles to kilometers\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("converting kilometers and miles\n");
                        Console.Write("Enter kilometer");
                        double kilometers = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Distance in Mi is : " + ConvertDistance.KMtoMi(kilometers));
                        break;
                    case 2:
                        Console.Write("converting miles to kilometers\n");
                        Console.Write("Enter miles");
                        double miles = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Distance in KM is : " + ConvertDistance.MitoKM(miles));
                        break;
                    default:
                        Console.Write("Enter valid option");
                        break;
                }
                Console.Write("\n\nWant to Continue?\n");
                Console.Write("1 : No\n");
                Console.Write("2 : Yes\n");
                exit = Convert.ToInt32(Console.ReadLine());

                if (exit == 1)
                {
                    Console.Write("\nExiting ....\n");
                    break;
                }

                Console.Write("\n\n");
            }
        }
    }

    public static class ConvertDistance
    {
        public static double MitoKM(double miles)
        {
            return miles * 1.60934;
        }

        public static double KMtoMi(double kilometers)
        {
            return kilometers * 0.621371;
        }
    }