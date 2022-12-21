// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерируем двумерный массив
int[,] Fill2DArrayIndexed(int countRow, int countColumn)
{
    int[,] matrix = new int[countRow,countColumn];

    for (int i = 01; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = i+j;
        }
    }
    return matrix;
}

// Печатаем двумерный массив
void Print2DArray(int[,] matrix)
{
    for (int i = 01; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] +"   ".Substring(matrix[i,j].ToString().Length)); // Печатает ровную таблицу
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] arr2D = Fill2DArrayIndexed(row, column);
Print2DArray(arr2D);