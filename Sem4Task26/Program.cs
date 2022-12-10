int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

int VariantLog(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int VariantSimple(int num)
{
    int count = 0;
    for (int i=0; i<num; i++)
    {
        num=num/10;
        count++;
    }
    return count;
}

int number = ReadData("Введите число А:");
int length1 = VariantLog(number);
int length2 = VariantSimple(number);
PrintData("Количество цифр в числе равно: " + length1);
PrintData("Количество цифр в числе равно: " + length2);