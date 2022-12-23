// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

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
            Console.Write(" "+matrix[i, j] + "      ".Substring(matrix[i,j].ToString().Length));
            Console.ResetColor();                                                   // Устанавливает исходный цвет
        }
        Console.WriteLine();
    }
}

//Метод, выводящий на печать массив
void Print1DArr(double[] arr)
{
    
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "   ");
    }
    Console.WriteLine(arr[arr.Length - 1] );
}

// Метод находит среднее арифметическое элементов в каждом столбце 
double[] AvgElem(int[,] array)
{
    double[] avgArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avgArray[j]+=array[i,j];
        }
        avgArray[j]=Math.Round(avgArray[j]/array.GetLength(0),2);
    }
    return avgArray;
}

int row = ReadData("Введите количество строк");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов");                           // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 1, 100);                                // Генерируем массив размером (row, column) с диапазоном значений от 1 до 99
Print2DArrayColor(arr2D);                                                       // Выводим на печать получившийся массив    
Console.WriteLine();
Print1DArr(AvgElem(arr2D));                                                     // Печатаем массив со средними значениями в каждом столбце


