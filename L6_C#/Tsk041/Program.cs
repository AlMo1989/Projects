// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Enter numbers quantity (M): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNums = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Enter {i+1} number: ");
    arrayNums[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int GetCompared(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count++; 
  }
  return count;
}

InputNumbers(m);
Console.WriteLine($"Entered numbers greater than zero: {GetCompared(arrayNums)} ");
