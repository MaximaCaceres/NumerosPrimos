using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8
{
    class Program
    {
        //iniciar contador de divisibilidad en cero.
        static int ContadorDivisores(int num)
        {
            int CantDivisores = 0;
            for(int i = 1; i <= num; i++) 
            {
                if(num % i == 0) 
                {
                    CantDivisores += 1;
                }
            }
            return CantDivisores;
        }
        static string DeterminarPrimo()
        {
            int num, acumD = 0;

            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine()); 

            acumD = ContadorDivisores(num);

            //verifico con de divisibilidad para saber si es primo
            if (acumD == 2)
            {
               return "es primo" ;
            }
            else
            {
                return "No es primo";
            } 

        }
        static void GenerarPrimos()
        {
            int desde, hasta;
            Console.WriteLine("ingrese desde y hasta");
            desde = Convert.ToInt32(Console.ReadLine());
            hasta = Convert.ToInt32(Console.ReadLine());

            for (int i = desde; i <= hasta; i++)
            {
                // Determinar si es primo usando ContadorDivisores
                int acumD = ContadorDivisores(i);

                // Verificar si es primo
                if (acumD == 2)
                {
                    // Mostrar el número evaluado si es primo
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            GenerarPrimos();
            Console.ReadKey();

        }

    }

    
   

}
