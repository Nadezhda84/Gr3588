// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array = GenArray(5, -100, 100);
Print1DArr(array);

int[] result = ConvertArray(array);
Print1DArr(result);
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] ConvertArray(int[] arr)
{
    int[] outArray = new int[arr.Length / 2 + 1];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        outArray[i] = arr[i] * arr[arr.Length - 1];

    }
    if (arr.Length % 2 != 0) outArray[outArray.Length]= arr[arr.Length / 2 - 1];
    return outArray;
}
