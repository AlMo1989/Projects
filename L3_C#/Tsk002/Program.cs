Console.Write("Введите число N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

string sqrtFind(int N) 
{ 
    string result = "";
    for (int i = 1; i <= N; i++)
    {
        result+=($"{Math.Pow(i, 2)}  ");
    }
    return result;
} 
Console.WriteLine($"{sqrtFind(N)}");