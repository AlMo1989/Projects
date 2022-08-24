// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Write($"Enter the number of array elements: ");
int elementsQuantity = Convert.ToInt32(Console.ReadLine()); 

int GetRandomNumbers(int elementsNum, int min, int max)
  {
  int[] randomNum = new int[elementsNum];
  int sumE = 0;
  Console.Write("Tooked array: ");

    for (int i = 0; i <randomNum.Length; i++)
    {
      randomNum[i] = new Random().Next(min, max);
      Console.Write($"{randomNum[i]} ");

      if (i % 2 != 1)
      {
        sumE = sumE + randomNum[i];
      }
    }
  return sumE;
  }

int randomNumbers = GetRandomNumbers(elementsQuantity, 1, 10);

Console.WriteLine($"\nThe sum of the odd elements in array: {randomNumbers}");
