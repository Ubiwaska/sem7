// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Enter the row: ");
int row_entered = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter the column: ");
int column_entered = int.Parse(Console.ReadLine() ?? "");

SearchForElement(array, row_entered, column_entered);


void SearchForElement(int[,] array, int row_entered, int column_entered)
{
    if (row_entered > array.GetLength(0) || column_entered > array.GetLength(1))
    {
        Console.WriteLine($"The entered position is beyond the size of the array ({array.GetLength(0)}, {array.GetLength(1)}).");
    }
    else
    {
        Console.WriteLine($"The array element value in row {row_entered} and column {column_entered} is {array[row_entered - 1, column_entered - 1]}");
    }

}


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