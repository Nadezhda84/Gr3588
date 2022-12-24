// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Факториал числа n
float Factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PrintPascalTriangle(int nRow)
{
    for (int i = 0; i < nRow; i++)
    {
        // создаем после каждой строки n-i отступов от левой стороны консоли,
        // чем ниже строка, тем меньше отступ
        for (int j = 0; i <= (nRow - i); j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {

            Console.Write(" ");
            Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
        }
        Console.WriteLine();    }
}

int countRow = ReadData("Введите количество строк треугольника Паскаля");                                 // Пользователь вводит количество строк
PrintPascalTriangle(countRow);
