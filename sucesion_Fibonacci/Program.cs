using System;
using System.Data;

namespace Program
{
    public class Fibonacci
    {
        public static void Main(String[] args)
        {
            //Colores para la consola, letra y fondo.
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            //Limpieza para utilizar el fondo.
            Console.Clear();

            //Se define un arreglo de tipo entero con la variable fibonnacci y se le dice que el tamaño vale 6, eso quiere decir que el for
            //Parara hasta sumar 6 veces.
            int[] fibonnacci = new int[50];
            //Se conoce 2 numeros en la sucesión, 0 y 1.
            fibonnacci[0] = 0;
            fibonnacci[1] = 1;
            //Se define variable para el for "Incremento"
            int i;
            
            //Empieza desde el 0 y finaliza en 6, incrementandolo.
            for (i = 0; i < 50; i++)
            {
                //Dice que si I es menor o igual a 1, es el resultado.
                if (i <= 1)
                {
                    fibonnacci[1] = i;
                } else
                {
                    //Cuando la variable resultado sea igual a la posición 0 y 1, lo sumará.
                    fibonnacci[i] = fibonnacci[0] + fibonnacci[1];
                    //Luego la posición del array 1 será igual al primer numero
                    fibonnacci[0] = fibonnacci[1];
                    //y la posición del array 2 será igual al segundo numero.
                    fibonnacci[1] = fibonnacci[i];
                    //En pocas palabras, se va formando una suma infinitiva. Lo que el 0 era el primer numero y el 1 era el segundo numero, 
                    // El 1 será el resultado y será el primer numero y el segundo será otro 1, porque si se sumo 0+1 el siguiénte será 1+1,
                    //Y el resultado será 2, luego 2+3 es igual a 5 y así hasta llegar al último tamaño del array que es 6 y parará el ciclo sumatorio.
                }
                //Muestra en pantalla el ultimo resultado alcanzado sumando.
                Console.WriteLine(fibonnacci[i]);
            }
            Console.ReadKey();
        }

    }
}