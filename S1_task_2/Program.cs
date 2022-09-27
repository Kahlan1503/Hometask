//Задача 2:Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите число 1");
int number_1 = int.Parse(Console.ReadLine ());
Console.WriteLine ("Введите число 2");
int number_2 = int.Parse(Console.ReadLine ());
// Поиск максимального и минимального числа
if(number_1>number_2)
{
    Console.WriteLine("max=");
    Console.WriteLine(number_1);
    Console.WriteLine("min =");
    Console.WriteLine(number_2);
}
else 
{
    Console.WriteLine("max =");
    Console.WriteLine(number_2);
    Console.WriteLine("min =");
    Console.WriteLine(number_1);
}