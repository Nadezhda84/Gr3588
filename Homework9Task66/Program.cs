// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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

// Метод с помощью рекурсии находит все натуральные элементы в промежутке от M до N
string RecMN(int M, int N)
{
    string outRes = string.Empty;
    if (M >= N) return outRes + N;
    outRes = M + " " + RecMN(M + 1, N);
    return outRes;
}

// Метод с помощи рекурсии находит сумму натуральных элементов в промежутке от M до N.
int RecSumMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return outRes + N;
    outRes = M + RecSumMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
Console.WriteLine();
string resultLine = number1 < number2 ? RecMN(number1, number2) : RecMN(number2, number1); // Тернарный оператор(если пользователь перепутал M и N)
PrintData(resultLine);
int resultSum = number1 < number2 ? RecSumMN(number1, number2) : RecSumMN(number2, number1); // Тернарный оператор (если пользователь перепутал M и N)
if (number1<number2) PrintData($"Cуммa натуральных элементов в промежутке от {number1} до {number2} равна {resultSum}"); // Если М < N
else PrintData($"Cуммa натуральных элементов в промежутке от {number2} до {number1} равна {resultSum}");                 // Если М > N