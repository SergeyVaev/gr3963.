    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
    // Например, задан массив: 
    // 1 4 7 2 
    // 5 9 2 3 
    // 8 4 2 4 
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

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
    Console.ForegroundColor = col[new Random().Next(0,16)];
    Console.Write(arr[i, j] + "\t ");
    Console.ResetColor();
    }
    Console.WriteLine();
    }
    }

    void Print1DArr(double[] arr)// метод печати одномерного массива
    {
        Console.Write("[");// указываем с чего будет начинаться вывод на экран 
        for (int i = 0; i < arr.Length - 1; i++)//счетчик,условия,действия которые мы будем выполнять 
        {
            Console.Write(arr[i] + "\t");//выводим результат через запятую  
        }
        Console.WriteLine(arr[arr.Length - 1] + "]");//заканчиваем вывод результата крайним числом и закрываем скобкой 
    }

    double[] ColMean2DArr(int[,] arr)//метод вывода среднего арифметического
    {
        double[] resArr = new double[arr.GetLength(1)];

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                resArr[j] += arr[i, j];
            }
            resArr[j] = resArr[j] / arr.GetLength(0);
        }
        return resArr;
    }
    int[,] mas = Gen2DArr(2,5,10,100);// вносим значения 
    Print2DArr(mas);//печатаем

    double[] colMean = ColMean2DArr(mas);//находим сумму в каждом столбе
    Print1DArr(colMean);//выводим результат с ср арифметическим
               


