using System;

namespace SobreCargados
{
    class Program
    {

        static int[] arreglo = null;
        static int[,] matriz = null;
        static int[,] matriz1 = null;
        static int[,] matrizR = null;
        static int[,] SumarMatrices = null;
        static int sumaFilas = 0;
        static int sumaColumnas = 0;
        int a;


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
                    suma += a[i, j];
                }
            }
            Console.WriteLine("La suma de la matriz es " + suma);
        }
        public static int[,] sumar(int[,] a, int[,] b)
        {
            int filas1 = a.Length;
            int columnas1 = a.Length;

            int filas2 = b.Length;
            int columnas2 = b.Length;

            if (filas1 == filas2 && columnas2 == columnas1)
            {
                matrizR = new int[filas1, columnas1];
                for (int i = 0; i < filas1; i++)
                {
                    for (int j = 0; j < columnas1; j++)
                    {
                        matrizR[i, j] = a[i, j] + b[i, j];
                    }
                }
                return matrizR;
            }
            else
            {
                Console.WriteLine("Las matrices deben tener la misma cantidad de filas que columnas");
            }
            Console.WriteLine("Matriz resultado:");
            for (int i = 0; i < filas1; i++)
            {
                for (int j = 0; j < columnas1; j++)
                {
                    Console.Write(matrizR[i, j] + "   ");
                }
                Console.WriteLine("");
            }
            return matrizR;
        }

        /* Console.WriteLine("suma de matrices");
             int suma = 0;
             for (int i = 0; i <a.GetLength(0); i++)
             {
                 for (int j = 0; j <b.GetLength(0); j++)
                 {
                     suma = matriz[i, j] + matriz1[i, j];

                 }

             }
             Console.Write("la suma de las matrices " + suma);
             for (int i = 0; i < a.GetLength(0); i++)
             {
                 Console.Write("\n");
                 for (int j = 0; j <b.GetLength(0); j++)
                 {
                     Console.Write(matrizR[i, j] + " ");
                 }
             }
         }*/
        public static void sumar(int[,] a, int Filas)
        {

            for (int i = 0; i < a.GetLength(0); i++)
            {      
                sumaFilas = sumaFilas + a[Filas - 1, i];
            }
            Console.WriteLine("La suma de la fila [" + Filas + "] es : = " + sumaFilas);
            Console.WriteLine("");

        } 
        public static void sumar(int Columnas, int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                sumaColumnas = sumaColumnas + a[i, Columnas-1];
            }
            Console.WriteLine("La suma de la fila [" + Columnas + "] es : = " + sumaColumnas);
            Console.WriteLine("");
        }
        public static void sumarTodos(int [,]a, int Filas)
        {
            Console.WriteLine("Suma de todas las filas de la matriz");
            Console.WriteLine("");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sumaFilas = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sumaFilas += a[i, j]; 
                    
                }

               
                Console.WriteLine("La suma de las filas en la posicion ["+ i +"] es : " +sumaFilas);

            }
            Console.WriteLine("");
        }
        public static void sumarTodos(int sumacolumnas, int[,] a)
        {
            Console.WriteLine("Suma de todas las columnas de la matriz");
            Console.WriteLine("");
            for (int j = 0; j < a.GetLength(1); j++)
            {
                sumacolumnas = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    sumacolumnas += a[i, j];    
                }
                Console.WriteLine("La suma de las columnas en la posicion [" + j + "] es : " + sumacolumnas);
            }
            Console.WriteLine("");
        }
        public static void leer(int c)
        {     
           arreglo = new int[c];
            for (int i = 0; i < c; i++)
            {      
                Console.Write("Ingresa el numero el la posicion [" + i + "] ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void leer(int c, int f)
        { 
            matriz = new int[c, f];
            matriz1 = new int[c, f];
            int op = 0;
            Console.WriteLine("Numero de matriz que desea leer");
            Console.WriteLine("No. 1 o No. 2 Eliga un solo numero");
            op = int.Parse(Console.ReadLine());
            switch(op){
                case 1: Console.WriteLine("Muy bien elegiste la No." + op);
                    for (int i = 0; i < c; i++)
                    {
                        for (int j = 0; j < f; j++)
                        {
                            Console.Write("Ingresa el numero el la posicion [" + (i) + "][" + (j) + "]: ");
                            matriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    break;
                case 2:Console.WriteLine("Muy bien elegiste la No." + op);
                    for (int i = 0; i < c; i++)
                    {
                        for (int j = 0; j < f; j++)
                        {
                            Console.Write("Ingresa el numero el la posicion [" + (i) + "][" + (j) + "]: ");
                            matriz1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    break;
            }           
        }
        public static void imprimir(int[] a)
        {
            Console.WriteLine("Los numeros del arreglo son los siguientes");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("En la posicion [" + i + "]" + " el numero  es " + "[" + a[i] + "] ");
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
            /*
            Console.WriteLine("Digite el tamaño del arreglo");
            int a = int.Parse(Console.ReadLine());
            leer(a);
            imprimir(arreglo);
            sumar(arreglo);
            */
            Console.WriteLine("Digite el tamaño de las columnas");
           int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tamaño de las filas");
            int f = int.Parse(Console.ReadLine());
            leer(c, f);
            imprimir(matriz);
            //  sumar(matriz);
            //sumar(matriz, 3);
            // sumar(3, matriz);
            Console.Write("Que No. de fila  que desea sumar : ");
            int fila = int.Parse(Console.ReadLine());
            sumar(matriz, fila);
            Console.Write("Que No. de columna que desea sumar : ");
            int columna = int.Parse(Console.ReadLine());
            sumar(columna, matriz);


            sumarTodos(matriz, 2);
            sumarTodos(2, matriz);


            //Console.WriteLine("Digite el tamaño de las columnas");
            // int a = int.Parse(Console.ReadLine());
            // Console.WriteLine("Digite el tamaño de las filas");
            // int b = int.Parse(Console.ReadLine());
            //leer(a, b);
            //imprimir(matriz1);
            // sumar(matriz1);
            //  sumar(matriz, matriz1);

        }
    }
}
