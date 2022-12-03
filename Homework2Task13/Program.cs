//Первый способ

// int number = int.Parse(Console.ReadLine() ?? "0");

// if (number > 99)                                                             //Проверяем, что в числе точно будет третья цифра
// {
//     char[] digits = number.ToString().ToCharArray();                         // Представляем число в виде массива символов
//     Console.WriteLine(digits[2]);                                            //Выводим на печать третью цифру числа
// }
// else Console.WriteLine("В веденном числе нет третьей цифры.");


// Второй способ

// int number = int.Parse(Console.ReadLine() ?? "0");
// int length = Math.Abs(number).ToString().Length;                             //Находим количество цифр в числе
// int index = 0;

// if (length > 3)                                                              //Проверяем, что в числе больше 3 цифр
// {
//     while (index < length - 3)                                               //Отрезаем с конца цифры, оставляем трехзначное число                           
//     {
//         number = number / 10;
//         index++;
//     }
//     Console.WriteLine(number % 10);                                          //Выводим на печать третью цифру числа
// }
// else Console.WriteLine("В веденном числе нет третьей цифры.");


//Третий способ

int DigitCount(int num)                                                         // Считаем количество цифр в числе
{
    int result = 0;
    while (num != 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}

int number = int.Parse(Console.ReadLine() ?? "0");
int amount = DigitCount(number);                                                
int index = 0;

if (amount > 3)
{
    while (index < amount - 3)                                                  //Отрезаем с конца цифры, оставляем трехзначное число
    {
        number = number / 10;
        index++;
    }
    Console.WriteLine(number % 10);                                             //Выводим на печать третью цифру числа
}
else Console.WriteLine("В веденном числе нет третьей цифры.");