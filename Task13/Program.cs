using static System.Console;
using System;

Clear();
Console.WriteLine("Здравствуйте!");
Console.WriteLine("Введте трёхзначное натуральное число:");
int N = Convert.ToInt32(ReadLine());

int a1=N%10;
int k=N/100;

if (k<1)
{
    WriteLine("третьей цифры нет");
}
else 
{
    Write("третьея цифра ");
    WriteLine(a1);
} 