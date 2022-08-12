// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.Write("Введи цифру, соответствующую дню недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("Это выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Дней в неделе всего 7");
  }
  else Console.WriteLine("Это не выходной день");
}

CheckingTheDayOfTheWeek(dayNumber);