﻿//Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(System.Console.ReadLine()!);

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
System.Console.WriteLine($"Максимальное число = {max}");