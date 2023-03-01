// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве

//Метод генерирующий массив.
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];// объявляем массив
    for (int i = 0; i < arr.Length; i++)//
    {
       arr[i]= arr[i]= new Random().Next(minValue, maxValue+1);//заполняем случайными числами из диапазона start до end
    }  
    return arr;//возвращаем значения в массив
}
//Метод,выводящий на печать данные пользователю.
void PrintData(string res)
{
    Console.WriteLine(res);
}
//Метод,выводящий массив на печать.
void Print1DArr(int[] arr)
{
    Console.Write("[");// указываем с чего будет начинаться вывод на экран
    for (int i = 0; i<arr.Length-1; i++)//счетчик,условия,действия которые мы будем выполнять
    {
        Console.Write(arr[i]+",");//выводим результат через запятую 
    }
    Console.WriteLine(arr[arr.Length-1]+"]");//заканчиваем вывод результата крайним числом и закрываем скобкой
}
int VariantNaive(int[]inputArray)
{
//Переменная накопления результата
int result=0;
//Буфферная переменная
int i=0;
//Пробегаемся по всем эллементам массива
while (i<inputArray.Length-1);
{
    //Сверяем эллемент.
    if (inputArray[i]%2==0);
    {
    //Подсчитываем результат
    result++;
    }
    //Увеличиваем инкремент.
    i++;
}
//Выводим результат
return(result);
}
int[]testArray = GenArray (123,100,999);
Print1DArr(testArray);
int result = VariantNaive(testArray);
PrintData(result.ToString());
