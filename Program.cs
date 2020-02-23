using System;

namespace SobreCargados
{
    class Program
    {

        private int[,] matrizA;
        private int[,] matrizB;
        private int[,] matrizC;
       

        

        public void Leer()
        {
            matrizA = new int[10, 10];
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
            for (int f = 0; f <=2; f++)
            {
                for (int c = 0; c <=2; c++)
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
