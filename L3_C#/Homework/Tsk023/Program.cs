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

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
  Console.WriteLine();
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);
