// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(10, 100);

//Выводим данные в консоль
Console.WriteLine(number);

//Получаем первую цифру и вторую цифру поотдельности
int firstNumber = number / 10;
int secondNumber = number % 10;

//Сравниваем числа
if(firstNumber>secondNumber)
{
    //Выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine(secondNumber);
}