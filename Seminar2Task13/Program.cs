//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
string Num = Console.ReadLine();
if (Num.Length >= 3)
{
char[]arr = Num.ToCharArray();
 Console.WriteLine (arr[2]);
}
else
{
    Console.WriteLine("третьего числа нет");
}