using static System.Console;
using System;

Clear();
Console.WriteLine("Салам алейкум, брат!");
Console.WriteLine("Введи трёхзначное натуральное число, брат:");
int N = Convert.ToInt32(ReadLine());

int a1=N/10;
int a2=a1%10;

Write("Вторая цифра твоего числа: ");
WriteLine(a2);