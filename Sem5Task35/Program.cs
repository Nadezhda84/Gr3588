// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = GenArray(123, -100, 100);
Print1DArr(array);

int result = CountElem(array, 10, 99);
PrintData("Количество элементов массива, значения которых лежат в отрезке [10,99], составляет " + result);

void PrintData(string res)
{
    Console.WriteLine(res);
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

void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

int CountElem(int[] arr, int min, int max)
{
    int count=0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]>=min && arr[i]<=max)
        {
            count++;
        }
    }
    return count;
}