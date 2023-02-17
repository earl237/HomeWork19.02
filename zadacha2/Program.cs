/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = -1;
if (num < 100) Console.Write("третей цифры нет");

else
{
    int i = 2;
    while (num / (Math.Pow(10, i)) > 10) i++;
    Console.Write($"{num} третье число {(num / Convert.ToInt32(Math.Pow(10, i - 2))) % 10}");
}