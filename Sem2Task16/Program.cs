

void Test(int number1, int number2)
{
    bool result = (number1 / number2 == number2);
    
    if (result) Console.WriteLine("Число " + number1 + " является квадратом числа " + number2);
    
    else Console.WriteLine("Число " + number1 + " не является квадратом числа " + number2);
    
}

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

Test(num1,num2);
Test(num2,num1);