// примает на вход число и возвращает сумму цифр числа

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

int RecSumDigit(int N)
{
    if (N < 10) return N;
    return N % 10 + RecSumDigit(N / 10);
}

int number = ReadData("Введите число N: ");
int sumDigit = RecSumDigit(number);
PrintData("Сумма цифр числа равна: " + sumDigit);