// Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//Получаем новое случайное число
int number = numberSintezator.Next(100, 1000);

//Выводим данные в консоль
Console.WriteLine(number);

//Получаем первую цифру и вторую цифру поотдельности
// int firstNumber = number / 100;
// int secondNumber = number % 10;



Console.WriteLine((number/100)*10 + number%10);