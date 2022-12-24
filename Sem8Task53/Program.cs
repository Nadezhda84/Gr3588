// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// Вывод цветного массива на печать
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(" " + matrix[i, j] + "      ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();                                                   // Устанавливает исходный цвет
        }
        Console.WriteLine();
    }
}

// Метод меняет местами первую и последнюю строку массива
void Change2DArray(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}

int row = ReadData("Введите количество строк");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов");                           // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 1, 100);   
Print2DArrayColor(arr2D);      
Change2DArray(arr2D);
Console.WriteLine();
Print2DArrayColor(arr2D); 