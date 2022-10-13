using System;

namespace Ejercicio_n_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //variables
            string dato1,dato2;
            int n1=0,n2=0,resultado=0;
            
            //pedir numero 1
            Console.WriteLine("Digite un numero: ");
            dato1 = Console.ReadLine(); 
            n1 = Convert.ToInt32(dato1);

            //pedir numero 2
            Console.WriteLine("Digite un numero: ");
            dato2 = Console.ReadLine(); 
            n2 = Convert.ToInt32(dato2);
            
            //operacion
            resultado = n1 + n2;

            //imprimir resultado en pantalla
            Console.WriteLine("El resultado es: {0}",resultado);
           
        }
    }
}
