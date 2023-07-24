/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/


Console.Write("Введите трехзначное число");
int trio = int.Parse(Console.ReadLine()!);
string trioString = trio.ToString();
if (trioString.Length >= 3)
{
    Console.WriteLine(trioString[1]);
}
else Console.WriteLine("число не корректно");
