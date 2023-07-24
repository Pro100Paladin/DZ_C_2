/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите трехзначное число");
int quad = int.Parse(Console.ReadLine()!);
string quadString = quad.ToString();
if (quadString.Length == 3)
{
    Console.WriteLine(quadString[2]);
}
else
{
    Console.WriteLine($"В числе {quadString} третьей цифры нет");
}