using System;

namespace Assiggnment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;              //declaring and initializing n
            double x, x1, x2, x3;   //declaring x,x1,x2,x3
            int greatZero = 0;      //declaring and intializing greaterzero,lesszero,equalzer
            int lessZero = 0;
            int equalZero = 0;

            // intializing was not used to 0 for min and max as there are values less than and greater than 0 so the program would output 0 in those cases
            double maximum = -2147483647;   //declaring max & initializing it to the most minimun value possible in c# so all values are greater than it
            double minimum = 2147483647;    //declaring max & initializing it to the most minimun value possible in c# so all values are greater than it
            double f = 0;                   //intializing and declaring f

            Console.WriteLine("How many Iterations of N or times will the program run?");  //Taking number of iterations from user
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input the value of x");       //taking user input for x
                double.TryParse(Console.ReadLine(), out x);

                Console.WriteLine("Input the value of x1");     //taking user input for x1  
                double.TryParse(Console.ReadLine(), out x1);

                Console.WriteLine("Input the value of x2");     //taking user input for x2
                double.TryParse(Console.ReadLine(), out x2);

                Console.WriteLine("Input the value of x3");     //taking user input for x3
                double.TryParse(Console.ReadLine(), out x3);



                if (x>=x1 && x<=x2)         //calculation f
                {
                    f = (x - x1) * (x3 - x1) / (x2 - x1);
                }
                else if (x2<x && x<=x3)
                {
                    f = (x - x2) * (x2 - x1) / (x3 - x2);
                }
                else if (x>x3)
                {
                    f = x3;
                }
                else
                {
                    Console.WriteLine("Value of function: invalid value");  //function not invalid
                    continue;                   //since invalid value proceed to next loop
                }

                Console.WriteLine("Value of function: " + f);  //printing f

                

                if (f>maximum)      //computing max value
                {
                    maximum = f;
                }

                if (f < minimum)    //computing min value
                {
                    minimum = f;
                }


                if (f>0)  //counting greater than, less than, equal to zero 
                {
                    greatZero = greatZero + 1;
                }
                else if (f<0)
                {
                    lessZero = lessZero + 1;
                }
                else if (f==0)
                {
                    equalZero = equalZero + 1;
                }


               //end loop
            }

            Console.WriteLine("The maximum value of all function: " + maximum);     //prininting max value
            Console.WriteLine("The minimum value of all function: " + minimum);     //priniting min value
            Console.WriteLine("The number of times f>0 (greater) is: " + greatZero);     //priniting greater value
            Console.WriteLine("The number of times f<0 (lesser) is: " + lessZero);     //priniting lesser value
            Console.WriteLine("the number of times f=0 (equal) is: " + equalZero);     //priniting equal value

        }
    }
}
