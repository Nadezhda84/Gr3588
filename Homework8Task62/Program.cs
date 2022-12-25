// Напишите программу, которая заполнит спирально массив 4 на 4.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Заполнение массива по спирали
int[,] FillSpiral2DArray(int n)
{
    int[,] outArray = new int[n, n];
    int iBegin = 0, iEnd = 0, jBegin = 0, jEnd = 0;          // Заводим угловые точки
    int i = 0, j = 0, k = 1;
    while (k <= n * n)
    {

        outArray[i, j] = k;
        if (i == iBegin && j < n - jEnd - 1)
            j++;
        else if (j == n - jEnd - 1 && i < n - iEnd - 1)
            i++;
        else if (i == n - iEnd - 1 && j > jBegin)
            j--;
        else
            i--;

        if ((i == iBegin + 1) && (j == jBegin) && (jBegin != n - jEnd - 1))
        {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;
        }
        k++;
    }

    return outArray;
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

int size = ReadData("Введите n - размерность матрицы n*n:");            // Пользователь вводит размерность матрицы   
int[,] arr2D = FillSpiral2DArray(size);                                 // Заполняем массив по спирали заданной размерности
Print2DArray(arr2D);                                                    // Печатаем получившийся массив