// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine()!);
}

int diffsq(int num1, int num2)
// разность чисел в квадрате (может быть, что это неуместно, но мне хотелось,
//чтобы вычисления в следующем методе выглядели менее громоздкими... )
{
    int num = Convert.ToInt32(Math.Pow(num2 - num1, 2));
    return num;
}

double distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double dis = Math.Round(Math.Sqrt(diffsq(ax, bx) + diffsq(ay, by) + diffsq(az, bz)), 2);
    return dis;
}

int[] a = new int[3];
int[] b = new int[3];

a[0] = ReadInt("Введите Х для точки A: ");
a[1] = ReadInt("Введите Y для точки A: ");
a[2] = ReadInt("Введите Z для точки A: ");
b[0] = ReadInt("Введите X для точки B: ");
b[1] = ReadInt("Введите Y для точки B: ");
b[2] = ReadInt("Введите Z для точки B: ");

double res = distance(a[0], a[1], a[2], b[0], b[1], b[2]);
Console.WriteLine($"Расстояние между точками = {res}");