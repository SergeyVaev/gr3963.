// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли, преобразование в целочисленное значение 
int ReadData(string line) 
{ 
    Console.Write(line); 
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number; 
} 

// Печать результата 
void PrintResult(int result) 
{ 
    Console.WriteLine("Сумма натуральных элементов: " + result); 
} 

// Рекурсивная функция для подсчета суммы натуральных элементов 
int RecSumDigMN(int m, int n) 
{ 
    int sum = m; 
    if (m >= n) 
    { 
        return n; 
    } 
    else 
    { 
        return sum + RecSumDigMN(m+1, n); 
    } 
} 

int number1 = ReadData("Введите число M: "); 
int number2 = ReadData("Введите число N: "); 
int resultLine = RecSumDigMN(number1, number2); 
PrintResult(resultLine);