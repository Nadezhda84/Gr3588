string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int number = int.Parse(inputNumber);
    if (number % 2 == 0)
    {
        Console.WriteLine("Число четное!");
    }
    else
    {
        Console.WriteLine("Число нечетное!");
    }
}