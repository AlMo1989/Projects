// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

int M = AskNumber("M");
int N = AskNumber("N");
Console.WriteLine($"M = {M}; N = {N}. -> \"{PrintRange(M, N)}\"");

string PrintRange(int M, int N) 
{
    if(N < M) return " ";
    string part = N == M ? $"{M}" : $"{M}, ";
    return part + PrintRange(M + 1, N);
}

int AskNumber(string name) 
{
    Console.Write($"Enter the number {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}