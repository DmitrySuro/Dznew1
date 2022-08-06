//Задача 2: Напишите программу, которая на вход принимает два 
//числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.Clear();

System.Console.WriteLine("Введите первое число");
int numberA = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите второе число");
int numberB = int.Parse(System.Console.ReadLine()!);
 
if (numberA < numberB)
{
    System.Console.WriteLine("Наибольшим числом будет: "+ numberB);
    System.Console.WriteLine("Наименьшим числом будет: "+ numberA);
}
else
{
    System.Console.WriteLine("Наибольшим числом будет: "+ numberA);
    System.Console.WriteLine("Наименьшим числом будет: "+ numberB);
}