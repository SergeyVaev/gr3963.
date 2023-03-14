// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли, преобразование в целочисленное значение 
int ReadData(string line) 
{ 
    Console.Write(line); 
    int number = int.Parse(Console.ReadLine() ?? "0"); 
    return number; 
} 
// Печать результата 
void PrintData(int result) 
{ 
    Console.WriteLine("Результат вычисления функции : " + result); 
} 
//Функция аккермана
              int ackermanFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return ackermanFunction(m - 1, 1);
            }
            else
            {
                return ackermanFunction(m - 1, ackermanFunction(m, n - 1));
            }
 
        }
        //чтение данных из консоли и вызов функции Аккермана
        int number1 = ReadData("Введите число M: "); 
        int number2 = ReadData("Введите число N: "); 
        int resultLine = ackermanFunction(number1, number2); 
        PrintData(resultLine);//печать результата вычислений