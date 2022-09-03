using System;

int x, y;
Console.WriteLine("Введите значение для Х ->");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для Y ->");
y = Convert.ToInt32(Console.ReadLine());
//int c = x;
//x = y;
//y = c;
x = x - y;
y = y + x;
x = -x + y;

Console.WriteLine($"x = {x} y = {y}");
