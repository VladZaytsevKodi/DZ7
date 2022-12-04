/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
 элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



//int[,] array = ArrayRandom(rows, cols);
//int[,] ArrayRandom (int minValue = -10, int maxValue = 10)
//{

    Console.WriteLine("введите колиество элементов в строке");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите колиество элементов в столбце");
int cols = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = ArrayRandom(rows, cols);
    int[,] ArrayRandom( int m, int n, int minValue = -10, int maxValue = 10)
    {
    int [,] array = new int [m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
             array[i, k] = rnd.Next(minValue, maxValue +1);
            Console.Write(array[i, k] + "\t ");
        }
        Console.WriteLine();       
    }
    return array;    
    }
    for (int k = 0; k < array.GetLength(1); k ++)
    {
        double sum  = 0;
        double averageSum = 0;
        for (int i = 0; i < array.GetLength(0); i ++)
        {
            sum += array[i, k];
            averageSum = sum / array.GetLength(1);
        }
        Console.WriteLine($"среднее арифметическое элементов в столбце = {averageSum} ");
        //Console.WriteLine( sum / array.GetLength(1));
    }
