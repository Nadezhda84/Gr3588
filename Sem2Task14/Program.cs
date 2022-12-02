int num = int.Parse(Console.ReadLine() ?? "0");

// int result1 = num % 7;
// int result2 = num % 23;


if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine("Да");
}
else
{
    Console.Write("Нет");
}