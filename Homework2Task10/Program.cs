int number = int.Parse(Console.ReadLine() ?? "0");

if (number > 99 && number < 1000)                                           //Проверяем, что число трехзначное
    Console.WriteLine((number / 10) % 10);                                  //Выводим на печать вторую цифру числа
else Console.WriteLine("Вы ввели не трехзначное число.");
