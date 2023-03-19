// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string ReadInt(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine()!;
}

void Pallindrome(string num)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}

string number = ReadInt("Введите пятизначное число: ");
if (number.Length == 5)
{
   Pallindrome(number);
}
else
{
    Console.WriteLine("Введено не пятизначное число.");
}