using System;

namespace SobreCargados
{
    class Program
    {
       
        static int[] arreglo = null;
        static int[,] matriz = null;
        
        
        public void sumar(int[] a)
        {

        }
        public void sumar(int[,] a)
        {

        }
        public void sumar(int[,] a, int[,] b)
        {

        }
        public void sumar(int[,] a, int r)
        {

        }
        public void sumar(int c, int[] a)
        {

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
            Console.WriteLine("Ingrese el tamaño de las filas");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de las filas");
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
                    Console.Write("Ingresa el numero el la posicion [" + i + "] ");
                    a[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
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
            Console.WriteLine("Los numeros de la matriz son los siguientes");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    
                    Console.Write( a[i,j]);
                   
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
       
        static void Main(string[] args)
        {
            arreglo = definirTamaño(arreglo);
            
            leer(arreglo);
            imprimir(arreglo);
            matriz = definirTamaño(matriz);
            leer(matriz);
           imprimir(matriz);
            
         
        }
    }
}
