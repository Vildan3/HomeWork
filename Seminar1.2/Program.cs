﻿// Задание третье, программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


int i;

Console.Write("Введите число : ");

i = Convert.ToInt32(Console.ReadLine());

if (i % 2 == 0)

{

    Console.Write("Введенное число является четным");

    Console.Read();

}

else

{

    Console.Write("Введенное число нечетное");

    Console.Read();

}