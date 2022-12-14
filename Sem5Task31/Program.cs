//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
int positivSum = 0;
int negativSum = 0;

int[] testArr=GenArray(12, -9,10);
NegativPositivSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", positivSum);
PrintData("Сумма отрицательных чисел в массиве: ", negativSum);


int[] GenArray(int len, int minValue, int maxValue)
{
    //Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void NegativPositivSum(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) positivSum += arr[i];
        else negativSum += arr[i];
    }
}

void Print1DArr(int[] arr)
{
     for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }
