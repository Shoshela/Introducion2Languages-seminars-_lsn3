﻿/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Enter namber...  ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} is palindrome");
    }
    else
    {
        Console.WriteLine($"{number} is not a palindrome");
    }
}
else
{
    Console.WriteLine($"{number} is not five-digit");
}