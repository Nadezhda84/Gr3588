// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Генерируем двумерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 01; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Печатаем двумерный массив
void Print2DArray(int[,] matrix)
{
    for (int i = 01; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] +"   ".Substring(matrix[i,j].ToString().Length));
        }
        Console.WriteLine();
    }
}

int CalcDiad(int[,] arr)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) res = res + arr[i,j];
        }

    }
    return res;
}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] arr2D = Fill2DArray(row, column, 1, 10);
Print2DArray(arr2D);
int result = CalcDiad(arr2D);
PrintData("Cуммa элементов, находящихся на главной диагонали равна:" + result);