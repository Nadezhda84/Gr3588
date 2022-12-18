// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив");
Print1DArr(array);

int[] copyArr = SwapNewArray(array);
Console.WriteLine("Новый массив перевернутый SwapNewArray методом");
Print1DArr(copyArr);
Console.WriteLine("Исходный массив");
Print1DArr(array);

int[] copyArrTwo= SwapArray(array);
Console.WriteLine("Исходный массив");
Print1DArr(array);
Console.WriteLine("Исходный массив, перевернутый SwapArray методом");
Print1DArr(copyArrTwo);

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Метод переворачивает массив, используя буферный элемент
int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

// Метод переворачивает массив, меняя первый элемент с последним и т.д.
int[] SwapNewArray(int[] arr)
{
    int[] outArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {

        outArray[i] = arr[arr.Length - 1 - i];
    }
    return outArray;
}