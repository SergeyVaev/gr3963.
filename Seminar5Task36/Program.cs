// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

//Принимаем из консоли число
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
void PrintData (string msg, int num)
{
    Console.WriteLine(msg+num);
}
int[] GenArr(int len, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[len];// объявляем массив
    for (int i = 0; i < arr.Length; i++)//
    {
       arr[i]= rnd.Next(min,max+1);//заполняем случайными числами из диапазона start до end
    }  
    return arr;//возвращаем значения в массив
}
void Print1DArr(int[] arr)
{
    Console.Write("[");// указываем с чего будет начинаться вывод на экран
    for (int i = 0; i<arr.Length-1; i++)//счетчик,условия,действия которые мы будем выполнять
    {
        Console.Write(arr[i]+",");//выводим результат через запятую 
    }
    Console.WriteLine(arr[arr.Length-1]+"]");//заканчиваем вывод результата крайним числом и закрываем скобкой
}
int OddSum(int[]arr)
{
int res=0;
for (int i=1; i<arr.Length; i= i+2)
{
    res=res+arr[i];
}
return res;
}
int Length = ReadData("Укажите диапазон длинны массива:");
int minValue = ReadData("Минимальное значение");
int maxValue = ReadData("Максимальное значение");
int[]mas=GenArr(Length,  minValue, maxValue);//заполнение массива случайными числами
Print1DArr(mas);
PrintData("Результат равен:", OddSum(mas));