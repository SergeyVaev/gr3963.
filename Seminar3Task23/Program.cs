//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadData (string msg)//считываем данные
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
string LineBuilder(int end, int pow)
{
    string res = String.Empty;// пустая строка
    for(int i = 1; i<=end ;i++)// счетчик,длительность,действия которые выполняем с переменной
    {
        res=res+Math.Pow(i,pow)+"\t";
    }
    return res;
}
int N = ReadData("Введите число N:");//команда для пользователя
Console.WriteLine(LineBuilder(N,1));//вывод данных
Console.WriteLine(LineBuilder(N,3));

