//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int number = ReadData("Введите количество элементов в массиве: ");
int minValue = ReadData("Введите нижний диапазон: ");
int maxValue = ReadData("Введите верхний диапазон: ");
int[] array = GenArray(number, minValue, maxValue);

Print1DArr(array);
int[] newArray = InverseArr(array);
Print1DArr(newArray);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

int[] InverseArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i] * (-1);
    }
    return outArr;
}