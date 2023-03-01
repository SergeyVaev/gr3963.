//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// Метод, генерирующий массив
double[] GenArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];// объявляем массив
    for (int i = 0; i < arr.Length; i++)//
    {
       arr[i]= new Random().Next(minValue, maxValue+1)+(new Random().NextDouble());//заполняем случайными числами из диапазона start до end
    }  
    return arr;//возвращаем значения в массив
}
void Print1DArray(double[] arr)
{
    Console.Write("[");// указываем с чего будет начинаться вывод на экран
    for (int i = 0; i<arr.Length-1; i++)//счетчик,условия,действия которые мы будем выполнять
    {
        Console.Write(arr[i]+",");//выводим результат через запятую 
    }
    Console.WriteLine(arr[arr.Length-1]+"]");//заканчиваем вывод результата крайним числом и закрываем скобкой
}
//сортировка методом пузырька
void BubbleSort (double[] array)
{
    for (int i = 0; i <array. Length; i++)
    for (int j = 0; j < array. Length - i - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            double buf = array[j];
            array[j] = array [j+1];
            array[j+1] = buf;
        }
    }
}
//связываем методы выводим
double[] testarray = GenArray(123,0,50);//размер, начало, конец
Print1DArray(testarray);//печатаем
BubbleSort(testarray);//сортируем
Print1DArray(testarray);//смотрим проверяем что он отсортирован
Console.WriteLine(testarray [testarray. Length-1]-testarray[0]);// выводим разницу между максимальным и минимальным