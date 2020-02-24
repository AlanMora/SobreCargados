using System;

namespace SobreCargados
{
    class Program
    {

        private int[,] matrizA;
        private int[,] matrizB;
        private int[,] matrizC;
        int filas, columnas;
        public void Leer()
        {
            
            matrizA = new int[10,10];
            matrizB = new int[10, 10];
            matrizC = new int[10, 10];
           

            Console.WriteLine("Ingresando datos al matriz A");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i  + "," + j +  "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    matrizA[i, j] = int.Parse(linea);
                }
            }
            for (int f = 1; f <= 2; f++)
            {
                
                for (int c = 1; c <= 2; c++)
                {
                    Console.Write(matrizA[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.WriteLine("Ingresando datos al matriz B");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    matrizB[i, j] = int.Parse(linea);
                }
            }
            for (int f = 1; f <= 2; f++)
            {
                
                for (int c = 1; c <= 2; c++)
                {
                    Console.Write(matrizB[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
        }
        public void Imprimir()
        {

            Console.WriteLine("Suma de las matrices es: ");
            Console.Write("");
            for (int f = 1; f <=2; f++)
            {
                
                for (int c = 1; c <=2; c++)
                {
                    Console.Write(matrizC[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
     
       
        static void Main(string[] args)
        {
            Program Leer = new Program();
            Leer.Leer();
            Leer.Imprimir();
        }
    }
}
