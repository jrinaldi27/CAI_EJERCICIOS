using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCAI
{
    class Ejercicios
    {

        public void ejercicio1()
        {
            for (int i = 1; i < 252; i++ )
            {
                if ((i%5 == 0 ) & (i%3 == 0))
                {
                    Console.WriteLine(i + "foo bar");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine(i + "foo");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine(i + "bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            

            
        }

    
    }
}
