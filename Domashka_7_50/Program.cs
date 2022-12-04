/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.*/


Console.WriteLine("введите позицию элемента в строке");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите позицию элемента в столбце");
int n = Convert.ToInt32(Console.ReadLine());

int rows = 3;
int cols = 4;

int[,] array = ArrayRandom(rows, cols);
int[,] ArrayRandom(int m, int n, int minValue = -10, int maxValue = 10)
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
if( m <= rows && n <= cols)
    {
    Console.WriteLine();
    Console.Write($"Элемент {m}{n} есть в массиве и равен {array[m,n]} ");
    }
else
    {
    Console.Write("Такого элемента нет");
    }            