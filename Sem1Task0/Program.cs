// нахождение квадрата числа

string? NumLine = Console.ReadLine();


if (NumLine != null)
{
    int num1 = int.Parse(NumLine);
   

    int outResult = num1 * num1;
    Console.WriteLine(outResult);
}
