
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
int inputNumber = int.Parse(inputLine);

int temp = inputNumber * (-1);

string outNumber = string.Empty;

while (temp < inputNumber)
{
    outNumber = outNumber + temp + ",";
    temp++;
}

outNumber = outNumber + inputLine;
Console.WriteLine(outNumber);
}