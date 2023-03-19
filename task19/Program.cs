// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// строковый метод
// string ReadInt(string text)
// {
//     Console.WriteLine(text);
//     return Console.ReadLine();
// }

// void Pallindrome(string num)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine($"{num} -> да");
//     }
//     else
//     {
//         Console.WriteLine($"{num} -> нет");
//     }
// }

// string number = ReadInt("Введите пятизначное число: ");
// if (number.Length == 5)
// {
//    Pallindrome(number);
// }
// else
// {
//     Console.WriteLine("Введено не пятизначное число.");
// }

// математический метод
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine()!);
}

void Pallindrome(int number)
{
    if (number/10000 == number%10 && number/1000%10 == number/10%10)
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}

int num = ReadInt("Введите пятизначное число: ");

if (num >= 10000 && num <= 99999)
{
    Pallindrome(num);
}
else
{
    Console.WriteLine("Введено не пятизначное число.");
}