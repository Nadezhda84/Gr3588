try
{
    double number1 = ReadData("Введите первое число: ");
    string oper = ReadStringData("Введите операцию: ");
    double number2 = ReadData("Введите второе число: ");
    double result = Сalculation(number1, oper, number2);
    PrintData(number1 + " " + oper + " " + number2 + " = " + result);
}
catch (Exception ex)
{
    PrintData(ex.Message);
}

double ReadData(string msg)
{
    Console.WriteLine(msg);
    return double.Parse(Console.ReadLine() ?? "0");
}

string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

double Pow(double num, double pow)
{
    return Math.Pow(num, pow);
}

double Sum(double num1, double num2)
{
    return num1 + num2;
}

double Diff(double num1, double num2)
{
    return num1 - num2;
}

double Mult(double num1, double num2)
{
    return num1 * num2;
}

double Div(double num1, double num2)
{
    if (num2 == 0)
        throw new Exception("Деление на ноль невозможно");
    else return num1 / num2;
}

double Сalculation(double number1, string oper, double number2)
{
    switch (oper)
    {
        case "+": return Sum(number1, number2);
        case "-": return Diff(number1, number2);
        case "*": return Mult(number1, number2);
        case "/": return Div(number1, number2);
        case "^": return Pow(number1, number2);
        default:
            throw new Exception("Недопустимая операция");
    }
}
