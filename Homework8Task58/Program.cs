// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
    for (int i = 0; i < countRow; i++)
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

// Умножение двух матриц
int[,] MultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] outMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) != matr2.GetLength(0)) throw new Exception("Данные матрицы невозможно перемножить. Введите корректные значения строк и столбцов");
    else
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int k = 0; k < matr2.GetLength(1); k++)
            {
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    outMatr[i, k] += matr1[i, j] * matr2[j, k];

                }
            }
        }
        return outMatr;
    }
}

try
{
    int row1 = ReadData("Введите количество строк первой матрицы");                                                         // Пользователь вводит количество строк первой матрицы
    int column1 = ReadData("Введите количество столбцов первой матрицы");                                                   // Пользователь вводит количество столбцов первой матрицы
    int[,] arr2D1 = Fill2DArray(row1, column1, 1, 9);                                                                       // Генерируем матрицу1 с заданным количеством строк и столбцов
    
    int row2 = ReadData("Введите количество строк второй матрицы (должно быть равно количеству столбцов первой матрицы)");  // Пользователь вводит количество строк второй матрицы
    int column2 = ReadData("Введите количество столбцов второй матрицы");                                                   // Пользователь вводит количество столбцов второй матрицы
    int[,] arr2D2 = Fill2DArray(row2, column2, 1, 9);                                                                       // Генерируем матрицу2 с заданным количеством строк и столбцов
    
    Console.WriteLine();
    Print2DArray(arr2D1);                                                                                                   // Печатаем матрицу1
    Console.WriteLine();
    Print2DArray(arr2D2);                                                                                                   // Печатаем матрицу2
    Console.WriteLine();

    int[,] resArr2D = MultMatrix(arr2D1, arr2D2);                                                                           // Перемножаем матрицы
    Print2DArray(resArr2D);                                                                                                 // Печатаем результат умножения двух матриц
}

catch (Exception ex)
{
    PrintData(ex.Message);
}