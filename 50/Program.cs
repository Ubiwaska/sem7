// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

if (rows > array.GetLength(0) || columns > array.GetLength(1))
{
    Console.WriteLine("This number is not in the array");
}
else
{
    Console.WriteLine($"Element {rows} row и {columns} column is {array[rows-1,columns-1]}");
}



void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine("");
    }
}