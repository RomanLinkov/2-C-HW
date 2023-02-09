using static System.Console;
using System;

Clear();
Console.WriteLine("Здравствуйте!");
Console.WriteLine("Введите номер для недели от 1 до 7");
int N = Convert.ToInt32(Console.ReadLine());

if (N<6)
{
    WriteLine("Это рабочий день.");
}
else 
{
    WriteLine("Это выходной день.");
} 