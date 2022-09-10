// Напишите программу, которая на вход принимает число 
// и ищет в двумерном массиве, и возвращает индексы этого 
// элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter number of array columns:");
bool columns = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Enter number of array rows:");
bool lines = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Enter the number to be found:");
bool DesiredNumber = int.TryParse(Console.ReadLine(), out int number);

int[,] CreatesArray(int str, int column)
{
    int[,] array = new int[str, column];
    Random random = new Random();
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = random.Next(0,10);
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

int[,] result = CreatesArray(m, n);
PrintArray(result);

void SearchingGivenNumber (int [,] array,  int DesiredNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (DesiredNumber == array[i,j])
            {
                Console.WriteLine($"Number {DesiredNumber} exist in array. his indexed adress: {i} , {j}");
            }
        }
    }
}
SearchingGivenNumber(result, number);