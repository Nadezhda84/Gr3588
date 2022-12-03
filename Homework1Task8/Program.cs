string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int number = int.Parse(inputNumber);
    string result = string.Empty;
    int count = 2;

    while (count <= number)
    {
        result = result + count  + " ";
        count = count + 2;
    }
    Console.WriteLine(result);
}