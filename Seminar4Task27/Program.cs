﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите значение для вычисления суммы его чисел:");
int n = int.Parse(Console.ReadLine()??"0");//вводим переменную и проверяем на пустоту

            int sum = 0;// вводим переменную и присваиваем ей значение 0
            while (n > 0)//до тех пор пока n не будет 0 выполняем следующие функции
            {
 
                sum = sum + n % 10;
                n = n /10 ;//убираем крайнюю цифру числа
 
            }
 Console.WriteLine(sum);// выводим результат