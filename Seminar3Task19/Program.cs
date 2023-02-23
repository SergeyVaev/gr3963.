//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadData (string msg)// считываем данные
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
int test = ReadData("Введите пятизначное число для проверки:");// выводим команду для пользователя, сюда же вернем ответ

bool PalinTest (int num)
{
bool res = false;// меиод с возвратом
if ((num/10000==num%10) && ((num/1000)%10) == ((num/10)%10))// заносим условия для определения палиндрома
{
    res = true;
}
return res;
}
{
if (PalinTest(test)==true) // тест на палиндром прошел успешно.

{
Console.WriteLine("данное значение является палиндромом!");
}
else
{
    Console.WriteLine("Данное значение является палиндромом! ");
}
}