// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.


int GetExpNumber(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
  {
    result = result * numA;
  }
   return result;
}

  Console.Write("Enter num A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter num B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exp = GetExpNumber(numberA, numberB);
  Console.WriteLine("Answer: " + exp);
