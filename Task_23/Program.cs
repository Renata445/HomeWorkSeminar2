﻿Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < n + 1; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
