﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите первое число:");
string strNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strNumber1); 
Console.WriteLine ("Введите второе число:");
string strNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strNumber2); 

if (number1 > number2)
{
    Console.Write("Максимальное: ");
    Console.WriteLine(number1);
}
else {
    Console.Write("Максимальное: ");
    Console.WriteLine(number2); 
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine ("Введите первое число:");
string strNumberA = Console.ReadLine();
int numberA = Convert.ToInt32(strNumberA); 
Console.WriteLine ("Введите второе число:");
string strNumberB = Console.ReadLine();
int numberB = Convert.ToInt32(strNumberB); 
Console.WriteLine ("Введите третье число:");
string strNumberC = Console.ReadLine();
int numberC = Convert.ToInt32(strNumberC); 

int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("Максимальное: ");
Console.WriteLine(max); 