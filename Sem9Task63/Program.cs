//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

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

string LineGenRec(int num)
{
    if (num <= 0) return string.Empty;
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintData(resultLine);