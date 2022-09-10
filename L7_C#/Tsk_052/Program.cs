// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Enter number of array colums:");
bool columns = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Enter number of array rows:");
bool lines = int.TryParse(Console.ReadLine(), out int m);

int[,] CreateArray(int str, int column)
{
    int[,] array = new int[str, column];
    Random random = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(0, 10);
        }


    }
    return array;
}

void PrintArray(int[,] array)
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

int[,] result = CreateArray(m, n);
Console.WriteLine();
PrintArray(result);

double[] FindArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result[i] = sum / array.GetLength(0);
    }
    return result;
}

double[] gap = FindArithmeticMean(result);

void PrintResult(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(Math.Round(array[i], 2));
    }
}

Console.WriteLine();
PrintResult(gap);