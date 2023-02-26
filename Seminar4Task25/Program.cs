//Задача 25: Напишите цикл, который принимает
 //на вход два числа (A и B) и возводит число A в натуральную степень B.

 int ReadData (string msg)//считываем данные. 
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
long Pow (int a, int b)// добавили тип,метод и переменные.
{
long res = 1;
while (b>0) 
{
res = res*a ;
b=b-1;
}
return res;//возвращаем полученные значения
}
int num1= ReadData("Введите число 1 :");
int num2=ReadData("Введите число2:");
Console.WriteLine(Pow(num1,num2));


