//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//добавляем инструкцию для пользователя
Console.WriteLine("Введите 3 числа, используйте клавишу ENTER:");

//добавляем переменные и сразу проверяем чтобы они не были пустыми
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
//добавляем ложный(if)
if (numA>numB)
{
    //начинаем сравнивать значения
if (numA>numC)
{
    Console.WriteLine("Первое число больше");
    }
    else
    {
        Console.WriteLine("Третье число больше");
    }
}
else
{
    if (numB>numC)
    Console.WriteLine("Второе число больше");
    else
    {
        Console.WriteLine("Третье число больше");
    }
}
