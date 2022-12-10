int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int VariantSumSimple(int numA)
{
    int sumOfNumber = 0;
    for (int i=1; i<=numA;i++)
    {
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

int VariantSumGause(int numA)
{
    int sumOfNumbers=0;
    sumOfNumbers= ((1+numA)*numA)/2;
    return sumOfNumbers;
}

int numderA = ReadData("Введите число А:");

DateTime d1 = DateTime .Now;
int res1 = VariantSumSimple(numderA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numderA);
Console.WriteLine(DateTime.Now-d2);

PrintData("Сумма чисел от 1 до А равна (простой метод): " + res1);
PrintData("Сумма чисел от 1 до А равна (метод Гауса): " + res2);
