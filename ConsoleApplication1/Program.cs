using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To MVC Cource - Pioneers Academy \n");
            Console.WriteLine("*****************************\n \n");
            Console.Write("Enter Number Of Student : ");
            int numofstudent = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Enter Number Of Cources : ");
            int numofcource = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n*****************************\n");
            double sum = 0;
            for(int i = 1; i <= numofstudent; i++)
            {
                Console.WriteLine("Student " + i);
                for(int k=1; k <= numofcource; k++)
                {
                    Console.Write("Entrer Mark Of Cource " + k + " : ");
                    double mark = double.Parse(Console.ReadLine());
                    if (mark > 100)
                    {
                        Console.WriteLine("Mark Must Less 101");
                        Console.Write("Entrer Mark Of Cource " + k + " : ");
                        mark = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                    sum = sum + mark;
                }
                double avg = sum / numofcource ;
                if (avg >= 50)
                {
                    Console.WriteLine("Student " + i + "  " + "Averge : "+avg+" , Result : Pass");
                }
                else
                {
                    Console.WriteLine("Student " + i + "  " + "Averge : " + avg + " , Result : Failed");
                }
                Console.WriteLine("-------------------------------------------------\n");
                sum = 0;

            }
            Console.WriteLine("Print Stars\n");
            for(int i = 10; i > 0; i--)
            {
                for(int j =0; j <i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }






            Console.ReadKey();

        }
       
    }
    }

