﻿//Напишите программу, которая принимает на вход число N  и выдаёт произвередение от 1 до N
 Console.Clear();
 Console.WriteLine("Введите число N: ");
 int n = int.Parse(Console.ReadLine());
 int result = 1;
for (int i = 1; i <= n; i++)
{
    result *= i;
}
 Console.WriteLine(n > 0 ? result : 0);