
string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}


void PrintData(string res)
{
    Console.WriteLine(res);
}

int SumDigitNumber(string s)
{
    int sum = 0;
    int num;
    bool isNum = int.TryParse(s, out num);
    if (isNum)
    {
        while (num != 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    }
    else PrintData("Вы ввели не число!");
    return sum;
}

int SumDigitString(string s)
{    
    int sum = 0;
    for (int i = 0; i < s.Length; i++)
    {
        sum = sum + (int)s[i] -48;
    }
    return sum;
}

string str = ReadStringData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = SumDigitNumber(str);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
int res2 = SumDigitString(str);
Console.WriteLine(DateTime.Now-d2);

PrintData("Сумма цифр числа (метод 1) равна: " + res1);
PrintData("Сумма цифр числа (метод 2) равна: " + res2);