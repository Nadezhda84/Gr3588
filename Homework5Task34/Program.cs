// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька

// Основное тело программы
try
{
    
    int number = ReadData("Введите количество элементов в массиве: ");                                          // Пользователь задает количество элементов в массиве
    int minValue = ReadData("Введите нижний диапазон (положительное трехзначное число): ");                     // Пользователь задает нижний диапазон числа в массиве
    int maxValue = ReadData("Введите верхний диапазон (положительное трехзначное число): ");                    // Пользователь задает верхний диапазон числа в массиве
    int[] array = GenArray(number, minValue, maxValue);                                                         // Генерируем массив с заданными параметрами
    PrintData("");                                                                                              // Печатаем пустую строку
    Print1DArr(array);                                                                                          // Выводим массив на печать
    int result = CountEven(array);                                                                              // Вызываем метод, подсчитывающий количество четных элементов в массиве
    PrintData("Количество четных элементов в массиве равно " + result);                                         // Выводим результат пользователю
    PrintData("");                                                                                              // Печатаем пустую строку
    int[] sortArray = BubbleSort(array);                                                                        // Сортируем массив методом пузырька
    PrintData("Отсортированный массив:");
    Print1DArr(sortArray);                                                                                      // Выводим на печать отсортированный массив
}
catch (Exception ex)
{
    PrintData(ex.Message);
}

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

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод, генерирующий массив, заполненный случайными положительными трёхзначными числами
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    if (minValue > 0 && maxValue > 0)
    {
        if (minValue >= 100 && minValue <= 999 && maxValue >= 100 && maxValue <= 999)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(minValue, maxValue + 1);
            }
        }
        else throw new Exception("Необходимо ввести трехзначное число! Повторите ввод.");
    }
    else throw new Exception("Необходимо ввести положительное число! Повторите ввод.");
    return arr;
}

// метод, подсчитывающий количество четных элементов в массиве
int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

// Сортировка пузырьком
int[] BubbleSort(int[] arr)
{
    for (int i=0; i<arr.Length;i++)
    {
        for (int j =0; j<arr.Length-1; j++)
        { 
            
            if(arr[j]>arr[j+1])
            {
                int temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
        }
    }
    return arr;
}