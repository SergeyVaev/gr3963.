    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
                // Например, задан массив: 
                // 1 4 7 2 
                // 5 9 2 3 
                // 8 4 2 4 
                // В итоге получается вот такой массив: 
                // 7 4 2 1 
                // 9 5 3 2 
                // 8 4 4 2 

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
                
                void Sort2DArray(int[,] arr)//метод сортировки по убыванию
                {
                    int[] row = new int[arr.GetLength(1)];

                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            row[j] = arr[i, j];
                        }

                        BubbleSort(row);// вызов метода

                        for (int j = 0; j < row.Length; j++)
                        {
                            arr[i, j] = row[j];
                        }

                    }
                }
                void BubbleSort(int[] arr)//метод сортировки методом пузырька 
                {
                    for (int j = 0; j < arr.Length; j++)
                        for (int k = 0; k < arr.Length - j - 1; k++)
                        {
                            if (arr[k] <arr[k + 1])
                            {
                                int buf = arr[k];
                                arr[k] = arr[k + 1];
                                arr[k + 1] = buf;
                            }
                        }

                }
       
    int[,] testArr= Gen2DArr(5,5,5,100);//задаем значения массива
    Print2DArr(testArr);//печатаем массив
    Sort2DArray(testArr);//вызов меода сортировки по убыванию
    Console.WriteLine();// разделение двух массивов пустой строкой
    Print2DArr(testArr);//печать отсортированного метода