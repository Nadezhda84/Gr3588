string ReadStringData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string NameChoice(string str)
{
    string[] names = str.Split(",");
    string name = names[new Random().Next(0, names.Length)].Trim();
    return name;
}

string str = ReadStringData("Введите имена через запятую: ");
PrintData("" + NameChoice(str));