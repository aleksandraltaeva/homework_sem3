// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine()!);
}

void NumberPow(int number)
{
    for (int i = 1; i <= number; i++)
    {
        System.Console.Write(Math.Pow(i, 3) + " ");
    }
}

int number = ReadInt("Введите число: ");
Console.Write($"{number} -> ");
NumberPow(number);