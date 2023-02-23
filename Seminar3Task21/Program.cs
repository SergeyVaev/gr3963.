// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadData (string msg)// считываем данные
{
Console.WriteLine(msg);
return int.Parse(Console.ReadLine()??"0");
}
void PrintData (string msg)//выводим сообщение
{
    Console.WriteLine(msg);
}
double CalkLen( int x1, int y1, int x2, int y2, int z1, int z2)// вносим переменные для точек
{
return Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));// выполняем вычисления и возвращаем результат
}
int x1 = ReadData("Введите координату х точки А:");//инструкция для пользователя
int y1 = ReadData ("Введите координату у точки А:");
int x2 = ReadData("Введите координату z точки A:");
int y2 = ReadData ("Введите координату х точки В:");
int z1 = ReadData ("Введите координату y точки B:");
int z2 = ReadData ("Введите координату z точки B:");

double res =CalkLen(x1, x2, y1, y2, z1, z2) ;

PrintData($"Растояние между точками А({x1},{y1},{z1}) и точкой B({x2},{y2},{z2}) = {res}");// выполнили расчет и отправили
