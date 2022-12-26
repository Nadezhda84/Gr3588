// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

// Вычисление функции Аккермана с помощью рекурсии
int RecAkk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return RecAkk(n - 1, 1);
    else
        return RecAkk(n - 1, RecAkk(n, m - 1));
}

int number1 = ReadData("Введите число m <= 3  ");
int number2 = ReadData("Введите число n <= 11 ");
Console.WriteLine();
int resultAkk = RecAkk(number1, number2);
PrintData($"Результат равен {resultAkk}");
