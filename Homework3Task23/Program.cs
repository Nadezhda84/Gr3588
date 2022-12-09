//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод выводит данные пользователю
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}
//Метод на выходе выдает строку со степенями чисел до number
string LineBilder(int num, int pow)
{
    string result = string.Empty;
    for (int i = 1; i < num; i++)
    {
        result = result + Math.Pow(i, pow) + " ";
    }
    result = result + Math.Pow(num, pow);
    return result;
}

int number = ReadData("Введите число: ");
PrintData("", LineBilder(number, 1));
PrintData("", LineBilder(number, 3));


// string s = "";
// for (int i = 0; i < number; i++)
// {
//     s = s + " -";
// }
// Console.WriteLine(s);
// Console.Write("|");
// PrintData("", LineBilder(number, 1));
// Console.WriteLine("|");
// Console.Write("|");
// PrintData("", LineBilder(number, 3));
// Console.WriteLine("|");

// Console.WriteLine(s);