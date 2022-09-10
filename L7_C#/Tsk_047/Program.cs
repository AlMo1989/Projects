// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

Console.WriteLine("Enter value m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] CreatesArray(int str, int column)
{
    double[,] array = new double[str, column];
    Random random = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            double element = Convert.ToDouble(random.Next(-100, 100) / 10.0);
            array[i, j] = element;
        }


    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] result = CreatesArray(m, n);
PrintArray(result);