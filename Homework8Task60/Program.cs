// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Создаем список чисел от 10 до 99
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

// Генерируем случайные двузначные числа
int GenNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outNum = num[index];
    num.Remove(index);
    return outNum;
}

// Генерируем трехмерный массив, заполненный случайными двузначными числами
int[,,] Fill3DArray(int x, int y, int z)
{
    //System.Random rand = new System.Random();
    int[,,] array3D = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = GenNum(num);
            }
        }
    }
    return array3D;
}

// Печатаем трехмерный массив вместе с индексами элементов
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "     ".Substring(matrix[i, j, k].ToString().Length));
            }
            Console.WriteLine();
        }
    }
}

int x = ReadData("Введите первую размерность");                             // Пользователь вводит количество элементов первой размерности                        
int y = ReadData("Введите вторую размерность");                             // Пользователь вводит количество элементов второй размерности
int z = ReadData("Введите третью размерность");                             // Пользователь вводит количество элементов третьей размерности

int[,,] arr3D = Fill3DArray(x, y, z);                                       // Генерируем массив с заданными параметрами
Print3DArray(arr3D);                                                        // Печатаем получившийся массив