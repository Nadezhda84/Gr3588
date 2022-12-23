// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

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

// // Генерируем двумерный массив, заполненный случайными числами
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     System.Random rand = new System.Random();
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = rand.Next(topBorder, downBorder + 1);
//         }
//     }
//     return array2D;
// }

// Метод заполняет массив числами Фибоначчи (числа Фибоначи идут и по строке и по столбцу) 
int[,] FillFibNum2DArray(int countRow, int countColumn, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];                                     
    for (int i = 0; i < 1; i++)                                                            // Заполняем первую строку числами Фибоначчи
    {
        array2D[i, 0] = 0;
        array2D[i, 1] = 1;
        for (int j = 2; j < countColumn; j++)
        {
            array2D[i, j] = array2D[i, j - 2] + array2D[i, j - 1];
        }
    }
    for (int i = 1; i < 2; i++)                                                           // Заполняем вторую строку числами Фибоначчи
    {
        array2D[i, 0] = 1;
        array2D[i, 1] = 1;
        for (int j = 2; j < countColumn; j++)
        {
            array2D[i, j] = array2D[i, j - 2] + array2D[i, j - 1];
        }
    }
    for (int i = 2; i < countRow; i++)                                                    // Заполняем остальной массив, используя первые две строки  
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = array2D[i - 2, j] + array2D[i - 1, j];
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
            Console.Write(matrix[i, j] + "       ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

// // Вывод цветного массива на печать
// void Print2DArrayColor(int[,] matrix)
// {
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new System.Random().Next(0, 16)];
//             Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
//             Console.ResetColor();                                                   // Устанавливает исходный цвет
//         }
//         Console.WriteLine();
//     }
// }

// Метод находит элемент в массиве по указанным индексам
int SearchElem(int[,] arr, int rowIndex, int colIndex)
{
    int res = -1;
    if (rowIndex < arr.GetLength(0) && colIndex < arr.GetLength(1)) res = arr[rowIndex, colIndex];
    return res;
}

// Метод выводит на печать массив и выделенный цветом найденный элемент в массиве
void PrintSearchNumColor(int[,] arr, int row, int column)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
                ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(arr[i, j] + "       ".Substring(arr[i, j].ToString().Length));
                Console.ResetColor();
            }
            else Console.Write(arr[i, j] + "       ".Substring(arr[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

// // Для простого задания

// int row = ReadData("Введите количество строк");
// int column = ReadData("Введите количество столбцов");
// int[,] arr2D = Fill2DArray(row, column, 10, 99);
// Print2DArrayColor(arr2D);
// int currentRow = ReadData("Введите номер строки");
// int currentCol = ReadData("Введите номер столбца");
// int elem = SearchElem(arr2D,currentRow, currentCol);
// if (elem==-1) PrintData("Такого числа в массиве нет");
// else PrintData($"На позиции [{currentRow},{currentCol}] находится число {elem}");

// // Для задачи *
int row = ReadData("Введите количество строк");                                 // Пользователь вводит количество строк в массиве
int column = ReadData("Введите количество столбцов");                           // Пользователь вводит количество столбцов в массиве
int[,] arrFibNum2D = FillFibNum2DArray(row, column, 15);                        // Заполняем массив числами Фибоначчи
Print2DArray(arrFibNum2D);                                                      // Печатаем получившийся массив
int currentRow = ReadData("Введите номер строки");                              // Пользователь вводит номер строки для поиска элемента в массиве
int currentCol = ReadData("Введите номер столбца");                             // Пользователь вводит номер столбца для поиска элемента в массиве
int elem = SearchElem(arrFibNum2D, currentRow, currentCol);                     // Ищем элемент по заданным номерам строки и столбца
if (elem == -1) PrintData("Такого числа в массиве нет");                        // Если элемент не найден
else PrintSearchNumColor(arrFibNum2D, currentRow, currentCol);                  // Печатаем массив с найденным элементом. Он выделен другим цветом
