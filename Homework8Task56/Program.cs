// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//  Находим номер строки и минимальную сумму элементов в строке
(int, int) MinSumStr(int[,] arr)
{
    int sumElem = 0;                                                             // Сумма элементов строки
    int minSum = int.MaxValue;                                                   // Наименьшая сумма элементов строки
    int numSrt = 0;                                                              // Номер строки с наименьшей суммой
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumElem = 0;                                                             
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumElem += arr[i, j];
        }
        if (sumElem < minSum)
        {
            minSum = sumElem;
            numSrt = i;
        }
    }
    return (numSrt, sumElem);
}

int row = ReadData("Введите количество строк");                                                        // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов");                                                  // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 10, 99);                                                       // Генерируем массив с заданным количеством строк и столбцов
Print2DArray(arr2D);                                                                                   // Печатаем получившийся массив
Console.WriteLine();
(int numStr,int sumElem) res = MinSumStr(arr2D);                                                       // Находим номер строки с минимальной суммой элементов в строке, а также саму сумму
PrintData($"В строке {res.numStr} минимальная сумма элементов, равная {res.sumElem}");                 // Выводим результат пользователю