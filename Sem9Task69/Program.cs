// Напишите прграмму, которая будет принимать 2 числа А и В 
// возведите А в степень В с помощью рекурсии


int number = ReadData("Введите число a: ");
int pow = ReadData("Введите число a: ");
long numPow1 = RecPow(number, pow);
long numPow2 = MyPow(number, pow);
PrintData($"{number} в степени {pow} равна: {numPow1}");
PrintData("" + numPow2);

// Чтение данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Печать результата
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Первый способ решения (последовательное возведение в степень)
long RecPow(int a, int b)
{
    if (b <= 1) return a;
    return a * RecPow(a, b - 1);
}

// Второй способ решения (возводим в степень частями, а потом результаты перемножаем)
long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    if (b == 1) return a;
    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
    }

}
