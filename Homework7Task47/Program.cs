// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генерируем двумерный массив, заполненный случайными вещественными числами
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = Math.Round(rand.NextDouble() + rand.Next(topBorder, downBorder + 1), 2);
        }
    }
    return array2D;
}

// Вывод цветного массива на печать
void Print2DArrayColor(double[,] matrix)
{
    string s = string.Empty;
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
            s = matrix[i, j].ToString();
            for (int k = 0; k < s.Length; k++)
            {
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(s[k]);
                Console.ResetColor();                                                   // Устанавливает исходный цвет
            }
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк");                             // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов");                       // Пользователь вводит количество столбцов
double[,] arr2D = Fill2DArray(row, column, 10, 99);                         // Генерируем массив размером (row, column) с диапазоном значений от 10 до 98
Print2DArrayColor(arr2D);                                                   // Выводим на печать получившийся массив
