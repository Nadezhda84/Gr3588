string? inputNumber1 = Console.ReadLine();
string? inputNumber2 = Console.ReadLine();
string? inputNumber3 = Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null && inputNumber3 != null)
{
    int number1 = int.Parse(inputNumber1);
    int number2 = int.Parse(inputNumber2);
    int number3 = int.Parse(inputNumber3);

    if (number1 > number2 && number1 > number3)
    {
        Console.WriteLine(number1);
    }
    else if (number2 > number1 && number2 > number3)
    {
         Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine(number3);
    }
}