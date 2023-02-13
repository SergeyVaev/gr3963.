//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// выводим надпись на экран
Console.WriteLine("Введите два числа через ENTER:");

// Вводим переменные
string numLine1 = Console.ReadLine();
string numLine2 = Console.ReadLine();

// проверяем чтобы данные не были пустыми

if (numLine1 != null && numLine2 != null)
{
    //Присваеваем переменным значения
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
// Сравниваем числа
if (num1 > num2)
{
    Console.WriteLine ("Первое число больше");
    }
    else if (num1<num2)
    {
        Console.WriteLine("Второе число больше");
    }
    else
    {
        Console.WriteLine("Числа равны");
    }

}
// конец


