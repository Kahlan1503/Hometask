//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number_3 = int.Parse(Console.ReadLine());
// Поиск максимального из этих чисел
int max = Math.Max(number_3, Math.Max(number_1, number_2));
Console.WriteLine($"Максимальное число : {max}");