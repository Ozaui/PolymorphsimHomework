using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphsimHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            Console.WriteLine("Welcome to shape app...");
            while (true)
            {
                Console.WriteLine("Please enter the option...");
                Console.WriteLine("1 => for Rectangle");
                Console.WriteLine("2 => for triangle");
                Console.WriteLine("q => for exit");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the rectangle name...");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter the rectangle's short edge...");
                    int shortEdge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the rectangle's long edge...");
                    int longEdge = Convert.ToInt32(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(name, shortEdge, shortEdge);
                    while (true)
                    {
                        
                        Console.WriteLine("1 => for calculate");
                        Console.WriteLine("2 => for information");
                        Console.WriteLine("q => for exit");
                        string rectangleOption = Console.ReadLine();
                        if(rectangleOption == "1")
                        {
                            rectangle.calculate();
                        }else if(rectangleOption == "2")
                        {
                            rectangle.showInformation();
                        }else if(rectangleOption == "q") 
                        {
                            break;
                        }
                    }
                }else if (option == "2")
                {
                    Console.WriteLine("Please enter the triange name...");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter the triangle's base...");
                    int @base = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the triangle's height...");
                    int @height = Convert.ToInt32(Console.ReadLine());
                    Triangle triangle = new Triangle(name, @base, @height);
                    while (true)
                    {
                        
                        Console.WriteLine("1 => for calculate");
                        Console.WriteLine("2 => for information");
                        Console.WriteLine("q => for exit");
                        string rectangleOption = Console.ReadLine();
                        if (rectangleOption == "1")
                        {
                            triangle.calculate();
                        }
                        else if (rectangleOption == "2")
                        {
                            triangle.showInformation();
                        }
                        else if (rectangleOption == "q")
                        {
                            break;
                        }
                    }
                }
                else if(option == "q") 
                {
                    Console.WriteLine("Exiting...");
                    break;
                }else
                {
                    Console.WriteLine("Your entry is incorrect");
                }
            }


            Console.ReadLine();
        }
    }
}
