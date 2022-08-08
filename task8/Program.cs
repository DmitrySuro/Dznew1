//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.Clear();

System.Console.WriteLine("Введите до какого числа нам искать четные числа ");
int N = int.Parse(System.Console.ReadLine()!);

int startNumber = 1;

System.Console.WriteLine("Вот ваши четные числа ");

while (startNumber <= N)
{
   if (startNumber % 2 == 0)
   {
        System.Console.WriteLine(startNumber);
   } 
    startNumber++;
}
