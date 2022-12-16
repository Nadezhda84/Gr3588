// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю

int number = ReadData("Введите количество элементов в массиве: ");                                          // Пользователь задает количество элементов в массиве
int minValue = ReadData("Введите нижний диапазон (положительное число): ");                                 // Пользователь задает нижний диапазон числа в массиве
int maxValue = ReadData("Введите верхний диапазон (положительное число): ");                                // Пользователь задает верхний диапазон числа в массиве
int[] array = GenArray(number, minValue, maxValue);                                                         // Генерируем массив с заданными параметрами
PrintData("");                                                                                              // Печатаем пустую строку
Print1DArr(array);                                                                                          // Выводим массив на печать
int result = SumOddElem(array);                                                                             // Вызываем метод, находящий сумму элементов, стоящих на нечётных позициях
PrintData("Cуммa элементов, стоящих на нечётных позициях равна " + result);                                 // Печатаем результат
PrintData("");
PrintData("Найденные пары в массиве:");
PairElem(array);                                                                                            // Вызываем метод, находящий пары в массиве и печатающий их пользователю

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

// Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    if (arr.Length == 0) return;
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод, находящий сумму элементов, стоящих на нечётных позициях
int SumOddElem(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}

// Метод, добавляющий новый элемент в массив
int[] AddToArray(int[] array, int elem)
{
    int[] res = new int[array.Length + 1];    // Создаем новый массив с длиной на 1 больше исходного массива
    array.CopyTo(res, 0);                     // Копируем исходный массив в новый, начиная с нулевого индекса 
    res[res.Length - 1] = elem;               // На последнее место в новый массив вставляем необходимый элемент
    return res;
}

// Метод, находящий все пары в массиве и выводящий их пользователю
void PairElem(int[] array)
{
    int[] arrayIndex = new int[0];                                                             // Создаем массив нулевой длины, в который будем записывать индексы второго вхождения числа

    for (int i = 0; i < array.Length; i++)
    {
        if (!arrayIndex.Contains(i))                                                          // Проверяем, обрабатывали ли мы раньше этот индекс
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])                                                     // Если два элементы массива равны
                {
                    Console.WriteLine(array[i] + ": " + "{" + i + "," + j + "}");              // Выводим найденную пару на печать
                    arrayIndex = AddToArray(arrayIndex, j);                                   // В новый массив добавляем индекс второго элемента пары
                    break;                                                                    // Прерываем работу цикла, т.к. пара найдена
                }

            }
        }
    }

}


