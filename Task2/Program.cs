﻿int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.WriteLine($"max = {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"max = {b}");
}
else if (c > a && c > b)
{
    Console.WriteLine($"max = {c}");
}
else
{
    Console.WriteLine($"Числа равны {a} = {b} = {c}");
}