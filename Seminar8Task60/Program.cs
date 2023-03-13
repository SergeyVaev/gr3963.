    // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
    //  которая будет построчно выводить массив, добавляя индексы каждого элемента

    int[,,] Gen3DArr (int row, int col, int dep, int min, int max) //метод генерации трехмерного массива
    {
    int[,,] arr = new int[row, col, dep];
     // Корректировка входных данных  
                    if (min > max)
                    {
                        int buf = min;
                        min = max;
                        max = buf;
                    }
    Random rnd = new Random(); 
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
            for (int k = 0; k < arr.GetLength(2); k++)//индекс указывающий глубину массива
                    {
                        arr[i,j,k] = rnd.Next(min, max + 1);
                    }
    }
    }
    return arr;
    } 

    void Print3DArr(int[,,] arr)//метод печати трехмерного массива
    {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    Console.Write("|");
     for (int j = 0; j < arr.GetLength(1); j++) 
    {
        for (int k = 0; k < arr.GetLength(2); k++)
         {
         Console.Write(arr[i,j,k] +" (" + i + ", " + j +", " + k +")\t");//создаем строку объединяязначения элемента массива и его индексы при помощи оператора(+)
         }
    }
    Console.WriteLine(); 
    } 
    }

    int[,,] array3D = Gen3DArr(2, 2, 2, 10, 99);//генерируем массив
    Print3DArr(array3D);//выводим
