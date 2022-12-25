// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

// Сортируем строки массива по убыванию методом пузырька
void BubbleSort2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}

int row = ReadData("Введите количество строк");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов");                           // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 10, 99);                                // Генерируем массив с заданным количеством строк и столбцов
Print2DArray(arr2D);                                                            // Печатаем получившийся массив
Console.WriteLine();
BubbleSort2DArray(arr2D);                                                       // Сортируем строки массива по убыванию методом пузырька
Print2DArray(arr2D);                                                            // Печатаем получившийся массив
