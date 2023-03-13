// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк 1 матрицы: ");//вводим данные с консоли
            int rowsA = int.Parse(Console.ReadLine()??"0");//проверяем чтобы данные не были пустыми
            Console.Write("Введите количество столбцов 1 матрицы: ");
    int columnsA = int.Parse(Console.ReadLine()??"0");
    Console.Write("Введите количество строк 2 матрицы: ");
          int rowsB = int.Parse(Console.ReadLine()??"0");
    Console.Write("Введите количество столбцов 2 матрицы: ");
    int columnsB = int.Parse(Console.ReadLine()??"0");
if (columnsA != rowsB)//если строки не совпадают со столбцами
{
  Console.WriteLine("Данные введенные для генерации матриц подлежат умножению!!!");
  return;
}
    int[,] A = Gen2DArr(rowsA, columnsA, 0, 10);//вызов метода генерации первой матрицы
    int[,] B = Gen2DArr(rowsB, columnsB, 0, 10);//вызов метода генерации второй матрицы
    Print2DArr(A);//печать первой матрицы
    Console.WriteLine();
    Print2DArr(B);//печать второй матрицы
    Console.WriteLine();
    Print2DArr(GenMultiplicationMatrix(A,B));//печать умноженных матриц

    int[,] Gen2DArr(int countRow, int countColumn, int min, int max)//инициализация двумерного массива  
                {
                    // Корректировка входных данных  
                    if (min > max)
                    {
                        int buf = min;
                        min = max;
                        max = buf;
                    }
                    Random rnd = new Random();//рандомайзер  
                    int[,] arr = new int[countRow, countColumn];
                    for (int i = 0; i < countRow; i++)//счетчик строк  
                    {
                        for (int j = 0; j < countColumn; j++)//счетчик столбцов  
                        {
                            arr[i, j] = rnd.Next(min, max + 1);
                        }
                    }
                    return arr;
                }

    void Print2DArr(int[,] arr)//метод печати сгенерированного массива 
                {
                    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,//разноцветное оформление 
                                ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                ConsoleColor.Yellow};

                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            Console.ForegroundColor = col[new Random().Next(0, 16)];
                            Console.Write(arr[i, j] + "\t ");
                            Console.ResetColor();
                        }
                        Console.WriteLine();
                    }
                }

    int [,] GenMultiplicationMatrix(int[,] arrayA, int[,] arrayB)//метод нахождения произведения двух матриц
    {
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];//создаем массив, в него закладываем столбцы и строки
      for (int i = 0; i < arrayA.GetLength(0); i++)//пробегаемся по столбцам
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)//пробегаемся по строкам
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];//формула для нахождения произведения двух матриц.
          }
        }
      }
      return arrayC;
    }
  

