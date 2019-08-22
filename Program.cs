using System;


namespace numero_mayor_multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {/*Programa que pida dos números al usuario muestre el menor de ellos
            y lo multiplique por si mismo. Por último presente el resultado*/
            //Declaraciondevariables
            int numero, numero1,resultado;
           //entrada de datos
            Console.WriteLine("Ingresa un numero");
            numero=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            numero1 = Convert.ToInt16(Console.ReadLine());
            //proceso
            if (numero<numero1)
            {
                resultado = numero * numero;
                Console.WriteLine("El menor es {0} y el resultado es {1}", numero,resultado);
            }
            else
            {
                resultado = numero1 * numero1;
                Console.WriteLine("El menor es {0} y el resultado es {1}", numero1, resultado);
            }
           
            //pausa
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadLine();


        }
    }
}
