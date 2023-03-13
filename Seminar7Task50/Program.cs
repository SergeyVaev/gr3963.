    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4

    int ReadData(string msg)//метод считывания данных
    {
    Console.WriteLine(msg);
    return int.Parse(Console. ReadLine ()??"0");
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
                    void Print2DArr(int[,] arr)// метод печати сгенерированного двумерного массива
    {
        ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                            ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                            ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                            ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                            ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                            ConsoleColor.Yellow};

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.ForegroundColor = col[new Random().Next(0,16)];
                Console.Write(arr[i, j] + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    void Print2DArrElem (int[,] arr, int row, int col)//метод для печати возвращяемого элемента
    {
    if (arr. GetLength (0)>row && arr. GetLength (1)>col)
    {
    Console.WriteLine(arr[row, col]) ;
    }
    else
    {
    Console.WriteLine("Такого элемента нет") ;
    }
    }
    int index1= ReadData("Введите индекс строки: ");
    int index2 = ReadData("Введите индекс столбца: ");
    int[,] testArr= Gen2DArr(10,10,123,100);//задаем значения массива
    Print2DArr(testArr);//печатаем массив
    Print2DArrElem(testArr, index1, index2) ;//выводим число с заданными нами индексами


