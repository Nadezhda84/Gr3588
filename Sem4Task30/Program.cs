int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArray(arr);
}

int[] GenArray(int len)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i=0; i <arr.Length;i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length-1; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine(array[array.Length-1] + "]");
}

int number = ReadData("Введите количество элементов в массиве: ");
int[] array = GenArray(number);
PrintData("Массив ", array);