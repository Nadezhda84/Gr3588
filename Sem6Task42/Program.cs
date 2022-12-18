// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int number = ReadData("Введите число:");
PrintData("Result: " + DecToBin(number));
PrintData("Result: " + DecToBinNativ(number));
//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, преобразующий десятичное число в двоичное
string DecToBin(int num)
{
    string outBin = string.Empty;
    while (num > 0)
    {
        outBin = (num % 2) + outBin;
        num /= 2;
    }
    return outBin;
}

// Встроенный метод, преобразующий десятичное число в двоичное
string DecToBinNativ(int num)
{
    return (Convert.ToString(num, 2));
}


