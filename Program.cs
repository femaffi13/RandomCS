using System;

namespace myfirstapp
{
    class Program
    {
        static void Main(){
            Random num = new Random();
            int numAleatorio = num.Next(0,100);

            int miNum = 101;   
            int intentos = 0;

            Console.WriteLine("Introducir un valor entre 0 y 100");

            while(numAleatorio != miNum){
                miNum = int.Parse(Console.ReadLine());
                if(miNum > numAleatorio) => Console.WriteLine("El número es más bajo");
                if(miNum < numAleatorio) => Console.WriteLine("El número es más alto");

                intentos++;
            }

            Console.WriteLine($"Correcto! Acertaste en ${intentos} intentos");
        }            
    }
}



