﻿// Задача 2. Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("Input first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if (numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);
*/



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;

if (number2 > maxNumber) maxNumber = number2;
if (number3 > maxNumber) maxNumber = number3;

Console.Write("maxNumber = ");
Console.WriteLine(maxNumber);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = number%2;

 if (even==0)
{
    Console.Write("Yes");
}
else 
{
    Console.WriteLine("No");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.Write("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= N)

{ Console.Write(current + " ");
current+=2; };
*/