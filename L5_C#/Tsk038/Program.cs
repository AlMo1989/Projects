// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
double[] arrayNums = new double[5];

  for (int i = 0; i < arrayNums.Length; i++ )
  {
    arrayNums[i] = new Random().Next(1, 100);
    Console.Write($"{arrayNums[i]} ");
  }


double minNum = arrayNums[0];
double maxNum = arrayNums[0];

  for (int i = 1; i < arrayNums.Length; i++)
  {
    if (maxNum < arrayNums[i])
    {
      maxNum = arrayNums[i];
    }
       if (minNum > arrayNums[i])
       {
         minNum = arrayNums[i];
       }
  }

  double result = maxNum - minNum;

Console.WriteLine($"\nDifference between MAX ({maxNum}) and MIN ({minNum}) elements is: {result}");
