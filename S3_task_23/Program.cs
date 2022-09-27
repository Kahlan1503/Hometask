// Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
string GetTripleTable(int n)
{
    string tripleString = "";
    if(n<1)
    { 
        return "Неверное число введено ";
    }
    else 
    {
    for (int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}";
        }
        else
        {
            tripleString = tripleString + $"{Math.Pow(i, 3)}, ";
        }
    }
    return tripleString;

}
}
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.Write($"Таблица кубов чисел от 1 до {x} = {GetTripleTable(x)}");
