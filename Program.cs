using System;

namespace myfirstapp
{
    class Program
    {
        static void Main(){
            Random num = new Random();

            int numAleatorio = num.Next(0,100);
            
            Console.WriteLine($"El valor es: {numAleatorio}");
        }            
    }
}



