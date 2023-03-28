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
                else if (i % 3 == 0)
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
            for (int i = 1; i < numero + 1; i++)
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
        public void ejercicio4()

        {
            Console.WriteLine("Ingrese la primer palabra");
            string palabra1 = Console.ReadLine().ToLower();
            Console.WriteLine("Ingrese la segunda palabra");
            string palabra2 = Console.ReadLine().ToLower();

            if (palabra1.Length != palabra2.Length)
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " no son anagramas");
            }

            else
            {
                int acumulador = 0;

                for (int i = 0; i < palabra1.Length; i++)
                {
                    for (int j = 0; j < palabra2.Length; j++)
                    {
                        if (palabra1[i] == palabra2[j])
                        {
                            palabra2 = palabra2.Remove(j, 1);
                        }
                    }
                }

                if (palabra2.Length == 0)
                {
                    Console.WriteLine("Las palabras son anagrama");
                }
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
                numeroAlReves += numero[posicion - 1];
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

            TimeSpan diferenciaFechas = (fechaIngresada - fechaActual);
            Console.WriteLine(diferenciaFechas);
        }

        public void ejercicio9()
        {
            string miUsuario = "JulianRinaldi";
            string inputUsuario = Console.ReadLine();

            if (inputUsuario == miUsuario)
            {
                Console.WriteLine("Hola " + miUsuario + " bienvenido");

            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }

        public void ejercicio10()
        {
            bool flag;
            char caracter;

            do
            {
                flag = false;


                if (!char.TryParse(Console.ReadLine().ToLower(), out caracter))
                {
                    Console.WriteLine("Usted no ingreso un caracter");
                }

                else
                {
                    flag = true;
                }
            } while (flag == false);

            if (char.IsDigit(caracter))
            {
                Console.WriteLine("El numero ingresado es" + caracter);
            }

            else if (caracter == 'a')
            {
                Console.WriteLine("Usted ingreso la vocal: " + caracter);
            }
            else if (caracter == 'e')
            {
                Console.WriteLine("Usted ingreso la vocal: " + caracter);
            }
            else if (caracter == 'i')
            {
                Console.WriteLine("Usted ingreso la vocal: " + caracter);
            }
            else if (caracter == 'o')
            {
                Console.WriteLine("Usted ingreso la vocal: " + caracter);
            }
            else if (caracter == 'u')
            {
                Console.WriteLine("Usted ingreso la vocal: " + caracter);
            }
            else
            {
                Console.WriteLine("Usted ingreso la consonante: " + caracter);
            }

        }

        public void ejercicio11()
        {
            Console.WriteLine("Ingrese nombre apellido y edad");
            string input = Console.ReadLine();
            string edad = "";
            string nombre = "";
            string apellido = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    edad += input[i];
                }
            }

            string cadenaSinNro = input.Trim(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ' });
            string[] palabras = cadenaSinNro.Split(' ');
            nombre = palabras[0];
            apellido = palabras[1];
            Console.WriteLine("Nombre: " + nombre + ", Apellido: " + apellido + ", Edad: " + edad);
        }

        public void ejercicio12()
        {
            Console.WriteLine("Ingrese la primer fecha");
            DateTime fecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda fecha");
            DateTime fecha2 = Convert.ToDateTime(Console.ReadLine());
            double resultadoDias;
            double resultadoAños;

            resultadoDias = Math.Abs((fecha1 - fecha2).TotalDays);
            resultadoAños = Math.Floor(resultadoDias / 365);
            resultadoDias = resultadoDias - resultadoAños * 365;
            double meses = Math.Floor(resultadoAños / 31);
            resultadoDias = resultadoDias - meses * 31;

            Console.WriteLine("La diferencia es de " + resultadoAños + " años, " + meses + " meses y " + resultadoDias + " días.");

        }

        public void ejercicio13()
        {
            Console.WriteLine("Ingrese numero para calcular el factorial");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            Console.WriteLine(resultado);

        }

        public void ejercicio14()
        {
            Console.WriteLine("Ingrese un numero para calcular su tabla de multiplicar");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[10];

            for (int i = 1; i < 11; i++)
            {
                numeros[i - 1] = i;
                Console.WriteLine(numero + "*" + i + " = " + (numero * i));
            }


        }
        public void ejercicio15()
        {
            string usuario = "Jr1234";
            string contraseña = "perrito1234";

            bool flag = false;
            bool flag2 = false;
            int intentos = 3;
            do
            {



                do
                {
                    Console.WriteLine("Por favor ingrese usuario:");
                    string usuarioIngresado = Console.ReadLine();
                    Console.WriteLine("Ingrese contraseña:");
                    string contraseñaIngresada = Console.ReadLine();

                    if (usuarioIngresado != usuario)
                    {
                        flag = true;
                        flag2 = false;
                        Console.WriteLine("Usuario no reconocido");

                    }
                    else if ((usuarioIngresado == usuario) & (contraseña != contraseñaIngresada))
                    {
                        intentos--;
                        Console.WriteLine("La contraseña ingresada es incorrecta le quedan " + intentos + " restantes");
                        if (intentos == 0)
                        {
                            Console.WriteLine("Usted se quedo sin intentos comuniquese con asistencia al usuario para recuperar su cuenta");
                            flag = true;
                            flag2 = true;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Bienvenido de nuevo" + usuarioIngresado);
                        flag = true;
                        flag2 = true;
                    }


                } while (flag == false);

            } while (flag2 == false);
        }

        public void ejercicio16()
        {
            Console.WriteLine("Ingrese un numero");
            string numero = Console.ReadLine();
            Console.WriteLine("Numero ingresado: " + numero + "tiene: " + (numero.Length) + " digitos");
        }

        public void ejercicio17()
        {
            string[,] datosEmpleados = new string[5, 2];
            bool flag;

            for (int i = 0; i < datosEmpleados.GetLength(0); i++)
            {
                string nombreEmpleado;
                string sueldoEmpleado;

                Console.WriteLine("Ingrese nombre del empleado");
                nombreEmpleado = Console.ReadLine();
                Console.WriteLine("Ingrese sueldo del empleado");
                sueldoEmpleado = Console.ReadLine();

                datosEmpleados[i, 0] = nombreEmpleado;
                datosEmpleados[i, 1] = sueldoEmpleado;


            }

            int[] sueldos = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nombre:" + datosEmpleados[i, 0] + " Sueldo:" + datosEmpleados[i, 1]);

                sueldos[i] = Convert.ToInt32(datosEmpleados[i, 1]);

            }
            Array.Sort(sueldos);

            Console.WriteLine("El salario mas alto es: " + sueldos[4]);


        }

        public void ejercicio18()
        {
            bool flag;
            Console.WriteLine("Ingrese un numero decimal para mostrar sus conversiones: ");
            int numero = 0;
            string binario;
            string octal;
            string hexa;

            do
            {
                flag = false;

                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Ud no ingreso un numero valido");
                }
                else
                {
                    flag = true;
                }


            }
            while (flag == false);

            binario = Convert.ToString(numero, 2);
            octal = Convert.ToString(numero, 8);
            hexa = Convert.ToString(numero, 16);


            Console.WriteLine("El numero ingresado en decimal es: " + numero + "\n"
                              + "En binario: " + binario + "\n" + "En octal:" + octal + "\n" + "En hexa: " + hexa);

        }

        public void ejercicio19()
        {
            Console.WriteLine("Ingrese la cantidad de palabras que desea ingresar: ");
            bool flag;
            int cantidad;

            do
            {
                flag = false;

                if (!int.TryParse(Console.ReadLine(), out cantidad))
                {
                    Console.WriteLine("Ud no ingreso un valor numerico");

                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            string[] listaDePalabras = new string[cantidad];

            for (int i = 0; i < listaDePalabras.Length; i++)
            {
                Console.WriteLine("Ingrese una palabra");
                listaDePalabras[i] = Console.ReadLine();
            }

            foreach (string palabra in listaDePalabras)
            {
                int largo = palabra.Length;
                Console.WriteLine(palabra + " tiene " + largo + " caracteres");

            }
        }

        public void ejercicio20()
        {

            int numero;
            int contador = 0;
            bool flag;

            Console.WriteLine("Ingrese un numero para calcular la cantidad de numeros primos entre el y 0 , y su factorial: ");
            do
            {
                flag = false;

                if (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Ud no ingreso un valor numerico");

                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            for(int i=1; i< numero; i++)
            {
                if(ChequearNumeroPrimero(i) == true)
                {
                    contador++;
                }
            }

            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            Console.WriteLine("La cantidad de numeros primos entre 0 y " + numero + " Es: " + contador);
            Console.WriteLine("El factorial de {0} es {1}", numero, resultado);


        }
    }
}
