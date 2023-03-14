// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

// Чтение данных из консоли,преобразование в целочисленное значение
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void LineGenRec(int currentNum,int maxNum)// функция для генерации последовательности от 1 до N при помощи рекурсии
{
    Console.Write(currentNum+" ");

    if (currentNum<maxNum)
    
    {
         LineGenRec(currentNum+1,maxNum);
    }
    
}
//чтение числа N с консоли и генерация последовательности чисел от 1 до N
int number = ReadData("введите число N: ");
LineGenRec(1,number);


