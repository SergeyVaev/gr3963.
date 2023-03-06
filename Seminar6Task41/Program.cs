// //Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int ReadData(string msg)//принимаем число из консоли
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void PrintData (string msg, int num)//метод выводящий на печать данные пользователю
{
    Console.WriteLine(msg+num);
}
int CountNum(int numN)//меиод определяющий положительные числа
{
    int res=0;
    for (int i=0; i<numN; i++)
    {
        if(ReadData ("")>0)
        {
            res++;
        }
    }
return res;
}
int numbN=ReadData("Введите числа: ");
PrintData("Положительных чисел:",CountNum(numbN));