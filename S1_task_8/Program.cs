// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int number_1 = int.Parse(Console.ReadLine());
if(number_1 != null)
{
     int i = 1;
   Console.WriteLine("Чётные числа");
    while(i<=number_1)
    { 
        if(i%2==0)
        {
            Console.WriteLine(i);
        }
        i++;

    }
}
