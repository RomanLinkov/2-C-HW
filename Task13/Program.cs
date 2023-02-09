using static System.Console;
using System;

Clear();
Console.WriteLine("Здравствуйте!");
Console.WriteLine("Введите натуральное число:");
string N = ReadLine();

int length=N.Length;
Write("количество цифр введённого числа ");
WriteLine(length);

int a1=0;
if (length<3)
{
    WriteLine("третьей цифры нет");
}
else 
{
    Write("третьея цифра ");
    WriteLine(N[2]);
} 