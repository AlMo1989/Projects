// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно 
//палиндромом.
/* 
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
 */


//Напишите программу, которая принимает на вход 
//координаты трех точек и находит расстояние между ними в 3D пространстве.

/* Console.Write("Enter x1: "); 
int coordAx = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter y1: "); 
int coordAy = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z1: "); 
int coordAz = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter x2: "); 
int coordBx = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter y2: "); 
int coordBy = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z2: "); 
int coordBz = Convert.ToInt32(Console.ReadLine()); 

double result = SearchDistance(coordAx, coordAy, coordAz, coordBx, coordBy, coordBz); 
double SearchDistance(int Ax, int Ay, int Az, int Bx, int By, int Bz) 
{ 
double sum = Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2);
//double sum = ((Bx - Ax) * (Bx - Ax)) + ((By - Ay) * (By - Ay)); 
double sqrt = Math.Sqrt(sum); 
return sqrt; 
} 
 
 
 Console.WriteLine(result);

 */



 //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Enter num.: "); 
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);