using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCAI
{
    class Ejercicios
    {

        public void ejercicio1()
        {
            for (int i = 1; i < 252; i++)
            {
                if ((i % 5 == 0) & (i % 3 == 0))
                {
                    Console.WriteLine(i + "foo bar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + "foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }



        }

        public void ejercicio2()
        {
            for (int i = 1; i < 252; i++)
            {
                if ((i % 3 == 0) & (ChequearNumeroPrimero(i) == true))
                {
                    Console.WriteLine(i + "Es multiplo de 3 y es primo");
                }

                else if (ChequearNumeroPrimero(i) == true)
                {
                    Console.WriteLine(i + "Es primo");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine(i + "Es multiplo de 3");
                }
                else
                {
                    Console.WriteLine(i);
                }
            
            
            }
        }

        public bool ChequearNumeroPrimero(int numero)
        {
            bool flag = false;
            int contador = 0;
            for (int i = 1; i < numero + 1 ; i++)
            {
                int numeroAEvaluar = numero % i;
                if (numeroAEvaluar == 0)
                {
                    contador++;
                }


            }
            if (contador <= 2)
            {
                flag = true;
            }
            return flag;
        }
    }
}
