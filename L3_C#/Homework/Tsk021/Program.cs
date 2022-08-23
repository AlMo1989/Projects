//Напишите программу, которая принимает на вход 
//координаты трех точек и находит расстояние между ними в 3D пространстве.

Console.Write("Enter x1: "); 
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