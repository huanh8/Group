using System;
using System.Linq;

namespace GroupC
{
    class Program
    {

        //method1
        static void method1()
        { 
        
        
        
        
        }
        //swap 2 numbers
        public static void swap(int num1, int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
        //method3
        static void method3()
        {
            Console.Clear();
            Console.WriteLine("empty for now");
            
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }






        static void Main(string[] args)
        {
            int selection;
            string[] title = { "method1", "method2", "method3", "Exit" };
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu".PadLeft(20));
                Console.WriteLine("Please Select a number".PadLeft(28));
                for (int i = 0; i < title.Length; i++)
                {
                    Console.Write((i +1).ToString().PadLeft(7).PadRight(11));
                    Console.WriteLine(title[i]);
                }
                // selection to call out task or exit the program
                selection = Convert.ToInt32(Console.ReadLine());
                
                switch (selection)
                {
                    case 1:
                        method1();
                        break;

                    case 2:
                        method2();
                        break;

                    case 3:
                        method3();
                        break;


                    default:
                        break;
                }
            } while (selection != 4);

        }
    }
}
