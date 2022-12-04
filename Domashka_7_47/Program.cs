// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = 3;
int cols = 4;

double[,] array = ArrayRandom(rows, cols);
double[,] ArrayRandom (int m, int n)
{
   double [,] array = new double [m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
            {
            array[i, k] = rnd.NextDouble();
            Console.Write(array[i, k] + "\t ");
            }
            Console.WriteLine();
    }
    return array;
} 