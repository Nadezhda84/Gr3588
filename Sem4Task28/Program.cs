using System.Numerics;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

BigInteger Factorial(int num)
{
    BigInteger factorial = 1;
    for (int i=1; i<= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}

int number = ReadData("Введите число: ");
BigInteger fact = Factorial(number);
PrintData("Факториал числа равен: " + fact);