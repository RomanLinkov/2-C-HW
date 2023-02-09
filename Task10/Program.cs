using static System.Console;
using System;

Clear();
Console.WriteLine("Здравствуйте!");
Console.WriteLine("Введте трёхзначное натуральное число:");
int N = Convert.ToInt32(ReadLine());

int a1=N/10;
int a2=a1%10;

Write("Вторая цифра введённого числа: ");
WriteLine(a2);