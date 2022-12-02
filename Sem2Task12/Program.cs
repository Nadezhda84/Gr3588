int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

int remainderOfDiv = num1 % num2;
if (remainderOfDiv == 0)
{
    Console.WriteLine(num1 + " делится на " + num2);
}
else
{
    Console.Write(num1 + " не делится на " + num2 + ". Остаток от деления: " + remainderOfDiv);
}