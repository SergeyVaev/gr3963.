// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит 
//их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.

int ReadData (string msg)//Ввод числа с экрана
{
    Console.WriteLine(msg);//выводим приглашение ко вводу
    return int.Parse(Console.ReadLine()??"0");//приводим к числу
}
//Метод для получения случайных значений массива
int[] GenArr(int num, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[num];// объявляем массив
    for (int i = 0; i < arr.Length; i++)//
    {
       arr[i]= rnd.Next(min,max+1);//заполняем случайными числами из диапазона start до end
    }  
    return arr;//возвращаем значения в массив
}
void PrintArr(int[] arr)
{
    Console.Write("[");// указываем с чего будет начинаться вывод на экран
    for (int i = 0; i<arr.Length-1; i++)//счетчик,условия,действия которые мы будем выполнять
    {
        Console.Write(arr[i]+",");//выводим результат через запятую 
    }
    Console.WriteLine(arr[arr.Length-1]+"]");//заканчиваем вывод результата крайним числом и закрываем скобкой
}
int Length = ReadData("Укажите диапазон длинны массива");
int min = ReadData("Минимальное значение");
int max = ReadData("Максимальное значение");
int[] arr = GenArr( Length, min, max);//заполнение массива случайными числами 
PrintArr(arr);// вывод результата
