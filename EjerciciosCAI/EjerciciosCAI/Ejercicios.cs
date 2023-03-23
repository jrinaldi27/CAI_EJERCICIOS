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


        public void ChequearPalindromo()
        {


            string palabraAChequear = Console.ReadLine();
            string palabraAlReves = "";
            int posicion = palabraAChequear.Length;

            for (int i = 0; i < palabraAChequear.Length; i++)
            {
                palabraAlReves = palabraAlReves + palabraAChequear[posicion - 1].ToString();
                posicion--;
            }

            Console.WriteLine(palabraAChequear);
            Console.WriteLine(palabraAlReves);

            if (palabraAChequear == palabraAlReves)
            {
                Console.WriteLine("Es palindromo");
            }
            else
            {
                Console.WriteLine("No es palindromo");
            }

        }

        public void ejercicio5()
        {
            Console.WriteLine("Ingrese un numero de 5 cifras");
            string numero = Console.ReadLine();
            string numeroAlReves = "";
            int posicion = numero.Length;

            for (int i = 0; i < numero.Length; i++)
            {
                numeroAlReves += numero[posicion-1];
                posicion--;
            }

            Console.WriteLine("El numero al reves es: " + numeroAlReves);
        }

        public void ejercicio6()
        {
            Console.WriteLine("Ingrese el primer termino");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo termino");
            int b = Convert.ToInt32(Console.ReadLine());

            int operacion = (a + b) * (a - b);

            Console.WriteLine("El resultado de la operacion es: " + operacion); 
        }

        public void ejercicio8()
        {
            DateTime fechaIngresada = Convert.ToDateTime(Console.ReadLine());
            DateTime fechaActual = DateTime.Now;

            TimeSpan diferenciaFechas = ( fechaIngresada - fechaActual);
            Console.WriteLine(diferenciaFechas);
        }
    }
}
