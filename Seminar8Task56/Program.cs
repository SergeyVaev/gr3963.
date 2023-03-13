// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

void PrintData( int res)// метод выводящий на печать данные пользователю
{
    Console.WriteLine(res);
}
     
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
                int MinRowCount(int[,]arr)//метод для поиска строки с минимальной суммой значений
                {
                    int index= -1;
                    int min= int.MaxValue;
                    for (int i =0; i<arr.GetLength(0); i++)
                    {
                        int sum =0;
                        for(int j =0;j<arr.GetLength(1);j++)//собрали сумму
                        {
                            sum=sum+arr[i,j];
                        }
                        if (sum<min)//проверяем чтобы сумма была минимальной
                        {
                            min=sum;// обновляем сумму
                            index=i;//обновляем индекс
                        }
                    }
                    return index;
                }
    int[,]testArr = Gen2DArr (5,5,5,10);//генерируем массив
    Print2DArr(testArr);//печатаем массив
    Console.WriteLine();
    PrintData(MinRowCount(testArr));
   
   
   
