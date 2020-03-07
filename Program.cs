using System;

namespace SobreCargados
{
    class Program
    {
       
        static int[] arreglo = null;
        static int[,] matriz = null;
        static int[,] matriz1 = null;
        static int[,] matrizR =  null;


        public static void sumar(int[] a)
        {
            int suma = 0;
            for (int i = 0; i < a.Length; i++)
            {
                suma += a[i];
            }
            Console.WriteLine("La suma del arreglo es " + suma);
        }
        public static void sumar(int[,] a)
        {
            int suma = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    suma += a[i,j];
                }
            }
            Console.WriteLine("La suma de la matriz es " + suma);
       
        }
        public static void sumar(int[,] a, int[,] b)
        {
            matrizR = new int[a.Length, b.Length];

            for (int i = 0; i <a.GetLength(0); i++)
            {

                for (int j = 0; j <b.GetLength(0); j++)
                {
                    matrizR[i, j] = matriz[i, j] + matriz1[i, j];
                }
              
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j <b.GetLength(0); j++)
                {
                    Console.Write(matrizR[i, j] + " ");
                }
            }




        }
        public static void sumar(int[,] a, int [] r)
        {
            int suma = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int filas = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    filas += a[i, j];
                    suma += a[i, j];
                    int res = filas  + suma;
                    Console.WriteLine(res);
                }
            }         
        }
        public static void sumar(int []c, int[,] a)
        {
            int suma = 0;
            for (int j = 0; j < a.GetLength(0); j++)
            {
                int columnas = 0;
                 for (int i = 0; i < a.GetLength(1); i++)
                {
                    columnas += a[i, j];
                    suma += a[i, j];
                    int res = columnas + suma;
                    Console.WriteLine(res);
                }
            }
        }
          public static int[] definirTamaño(int []a)
        {
            Console.WriteLine("Ingrese el tamaño del vector");
            int tam = int.Parse(Console.ReadLine());
            a = new int[tam];
            return a;
        }
        public static int[,] definirTamaño(int[,] a)
        {
            Console.Write("Ingrese el tamaño de las Filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tamaño de las Columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            a = new int[filas, columnas];
            return a;
        }
         public static void leer(int[] c)
        {
            Console.WriteLine("Digite los numeros del arreglo");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("Ingresa el numero el la posicion [" + i + "] ");
                c[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void leer(int[,]a)
        {
            Console.WriteLine("Digite los numeros de la matriz");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("Ingresa el numero el la posicion [" + (i)  + "][" + (j) + "]: ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
         public static void imprimir( int []a)
          {
              Console.WriteLine("Los numeros del arreglo son los siguientes");
              for (int i = 0; i < a.Length; i++)
              {
                  Console.WriteLine("En la posicion [" + i + "]" + " el numero  es "+"[" + a[i] + "] ");
              }
                 Console.WriteLine();

          }


        public static void  imprimir(int[,]a)
        {
            Console.WriteLine("Matriz : ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    
                    Console.Write( a[i,j] + " ");
                   
                }

                Console.WriteLine();
            }

       
        }
       
        static void Main(string[] args)
        {
             arreglo = definirTamaño(arreglo);

             leer(arreglo);
             imprimir(arreglo);
             sumar(arreglo);
             matriz = definirTamaño(matriz);

            leer(matriz);
             imprimir(matriz);
            sumar(matriz);
            matriz1 = definirTamaño(matriz1);
            leer(matriz1);
            imprimir(matriz1);
            sumar(matriz1);
            sumar(matriz, matriz1);
            sumar(matriz, arreglo);
         //   sumar(arreglo,matriz);
       



        }
    }
}
