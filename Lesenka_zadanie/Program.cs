
//вариант решения где считают количество лесенок(ступеней) при таком количестве кубиков
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введите количество кубиков: ");
//        int cubesCount = int.Parse(Console.ReadLine());

//        int stairsCount = CalculateMaxStairsCount(cubesCount);
//        Console.WriteLine($"Максимальное количество лестниц: {stairsCount}");

//        DrawStairs(stairsCount);
//    }

//    // Метод для подсчета максимального количества лестниц
//    static int CalculateMaxStairsCount(int cubesCount)
//    {
//        int stairsCount = 0;
//        int currentLayerCubesCount = 1;

//        while (cubesCount >= currentLayerCubesCount)
//        {
//            stairsCount++;
//            cubesCount -= currentLayerCubesCount;
//            currentLayerCubesCount++;
//        }

//        return stairsCount;
//    }

//    // Метод для визуального вывода лестниц на консоль
//    static void DrawStairs(int stairsCount)
//    {
//        int currentLayerCubesCount = 1;
//        for (int i = 1; i <= stairsCount; i++)
//        {
//            for (int j = 1; j <= currentLayerCubesCount; j++)
//            {
//                Console.Write("0 ");
//            }
//            Console.WriteLine();
//            currentLayerCubesCount++;
//        }
//    }
//}


//вариант решения, где считают всевозможное количество вариаций лестниц
using System;

namespace Stairs
{
    class Program
    {
        static int CountVariations(int n)
        {
            if (n <= 1)
                return 1;

            int[] variations = new int[n + 1];
            variations[0] = variations[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                variations[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    variations[i] += variations[j];
                }
            }

            return variations[n];
        }

        static void PrintStaircase(int n)
        {
            int[,] staircase = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    staircase[i, j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(staircase[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество кубиков: ");
            int n = int.Parse(Console.ReadLine());

            int variations = CountVariations(n);

            Console.WriteLine("Максимальное количество вариаций лестниц: " + variations);
            Console.WriteLine("Пример лестницы:");
            PrintStaircase(n);

            Console.ReadLine();
        }
    }
}

