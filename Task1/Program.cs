﻿int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}\nmin = {b}");
}
else if (a < b)
{
    Console.WriteLine($"max = {b}\nmin = {a}");
}
else
{
    Console.WriteLine($"Числа равны {a} = {b}");
}

