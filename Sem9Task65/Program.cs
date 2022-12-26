// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

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

string RecMN(int M, int N)
{
    string outRes = string.Empty;
    if (M >= N) return outRes + N;
    outRes = M + " " + RecMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
string resultLine = number1 < number2 ? RecMN(number1, number2) : RecMN(number2, number1); // Тернарный оператор(если пользователь перепутал M и N)
PrintData(resultLine);