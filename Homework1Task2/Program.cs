string? inputNumber1 = Console.ReadLine();
string? inputNumber2 = Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null)
{
    int number1 = int.Parse(inputNumber1);
    int number2 = int.Parse(inputNumber2);

    int outputNumber = (int) Math.Max(number1, number2);
    Console.WriteLine(outputNumber);
}