﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void SecondNumber(int a)
{
    if (a > 99 && a < 1000)
    {
        int result = a / 10 % 10;
        Console.WriteLine($"Вторая цифра числа {a} = {result}");
    }
    else if (a > -1000 && a < -99)
    {
        a = a * -1;
        int result = a / 10 % 10;
        Console.WriteLine($"Вторая цифра числа {-a} = {result}");
    }
    else { Console.WriteLine("Введено некорректное число!"); }
}
Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
SecondNumber(number);
