using System;


namespace Testovoe
{
    class Program 
    {
       


        static void Main()
        {
            Console.WriteLine("Enter number 1");
            int a = int.Parse(Console.ReadLine() ) ;

            Console.WriteLine("Enter number 2");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine( "+, - , / , *" );
            string c = Console.ReadLine();


            switch (c){
                case "+":
                      Console.WriteLine( a + b);
                    break;

                    case "-":
                    Console.WriteLine( a - b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Error");
                     }
                    else
                       Console.WriteLine (a / b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;


                    


            }

            



   





        }




    }

}