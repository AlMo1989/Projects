// Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    
    for (int index = 0; index < lenght; index++)
    {
        collection[index] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
   
    for (int position = 0; position < count; position++)
    {
        Console.Write(col[position] + ", ");
    }
}


int [] array = new int[8];

FillArray(array);
PrintArray(array);
Console.WriteLine();

