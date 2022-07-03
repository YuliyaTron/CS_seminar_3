// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("ВВедите целое пятизначное число: ");
Console.WriteLine("Введите координаты точки A: ");
Console.Write("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B : ");
Console.Write("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int a1, int b1, int c1, int a2, int b2, int c2)
{
    double res = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1) + (c2 - c1) * (c2 - c1));
    res = Math.Round(res, 2);
    return res;
}
double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);

