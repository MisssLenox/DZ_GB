﻿// Задача 4:
// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чиселю
Console.WriteLine("Ведите три числа: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_1 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}
Console.WriteLine("Наибольшее из введенных чисел -> " + max);
