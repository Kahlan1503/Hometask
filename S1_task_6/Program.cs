//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//Проверка является число чётным или нёчетным:
if (number % 2 == 0)
{
Console.Write("Чётное число");
}
else
{
Console.Write("Нечётное число");
}