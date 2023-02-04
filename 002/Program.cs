// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("введите координату X 1 точки");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Y 1 точки");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Z 1 точки");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату X 2 точки");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Y 2 точки");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите координату Z 2 точки");
double z2 = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"расстояние между точками = {s}");