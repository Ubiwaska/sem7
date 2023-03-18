// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

 double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i, j] = Math.Round(new Random().NextDouble()*(maxValue - minValue) + minValue,1);
        }
    }
    return result;
}
 void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

