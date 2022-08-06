//Задача 6: Напишите программу, которая на вход 
//принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.Clear

System.Console.WriteLine("ghf");
int number = int.Parse(System.Console.ReadLine()!);

if (number%2 == 0) System.Console.WriteLine($"Ваше число четное - {number}");
if (number%2 == 1) System.Console.WriteLine($"Ваше число нечетное - {number}");
