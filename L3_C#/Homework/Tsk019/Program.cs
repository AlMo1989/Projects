// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно 
//палиндромом.

Console.Write("Enter num.: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
if (number!.Length == 5)
{
  if (number[0] == number[4] || number[1] == number[3])
  {
    Console.WriteLine($"Your num: {number} - is Palindrome");
  }
  else Console.WriteLine($"Your num.: {number} - is NOT Palindrome.");
}
else Console.WriteLine($"Enter correct num.");
}

CheckingNumber(number!);