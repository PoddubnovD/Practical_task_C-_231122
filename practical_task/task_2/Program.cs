﻿Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine( num1+ " > " + num2);
}
else if (num2 > num1)
{
    Console.WriteLine( num2+ " > " + num1);
}
else
{
    Console.WriteLine( num2+ " = " + num1);
}