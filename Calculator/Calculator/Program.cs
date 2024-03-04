using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.Write("Pilih Menu Calculator\n\n\t1.Penjumlahan\n\t2.Pengurangan\n\t3.Perkalian\n\t4.Pembagian\n\nInput Choice\t: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                Console.Write("Input First Number\t: ");
                int fNum = int.Parse(Console.ReadLine());

                Console.Write("Input Second Number\t: ");
                int sNum = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("{0} + {1} = {2}", fNum, sNum, Penambahan(fNum, sNum));
            }
            else if (choice == 2)
            {
                Console.Write("Input First Number\t: ");
                int fNum = int.Parse(Console.ReadLine());

                Console.Write("Input Second Number\t: ");
                int sNum = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("{0}- {1} = {2}", fNum, sNum, Pengurangan(fNum, sNum));
            }
            else if (choice == 3)
            {
                Console.Write("Input First Number\t: ");
                int fNum = int.Parse(Console.ReadLine());

                Console.Write("Input Second Number\t: ");
                int sNum = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("{0} x {1} = {2}", fNum, sNum, Perkalian(fNum, sNum));
            }
            else if(choice == 4)
            {
                Console.Write("Input First Number\t: ");
                int fNum = int.Parse(Console.ReadLine());

                Console.Write("Input Second Number\t: ");
                int sNum = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("{0} / {1} = {2}", fNum, sNum, Pembagian(fNum, sNum));
            }
            else
            {
                Console.WriteLine("Invalid Index!");
            }


 
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static float Pembagian(float a, float b)
        {
            return a / b;
        }
    }
}
