// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

string str = ReadData("Введите числа в формате: a b c d ...");
int[] numbers = StringToInt(str);
int count = CountPozitive(numbers);
PrintData("Количество положительных чисел равно: " + count);

// Метод, считывающий данные, введенные пользователем
string ReadData(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine() ?? "0";
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод, преобразуюший строку чисел в массив чисел
int[] StringToInt(string str)
{
    string[] str1 = str.Split(" ");                         // Разбиваем строку по "пробелу"     
    int[] numbers = new int[str1.Length];                   // Создаем новый массив, в который запишем числа
    for (int i = 0; i < str1.Length; i++)
    {
        numbers[i] = int.Parse(str1[i]);                    // Преобразуем строку в число    
    }
    return numbers;
}

// Метод, считающий количество положительных чисел введенных пользователем
int CountPozitive(int[] num)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) count++;
    }
    return count;
}


// Console.WriteLine("Введите символы. По окончании ввода нажмите Enter");
// int Test()
// {
//     ConsoleKeyInfo cki;
//     int count = 0;

//     while (true)
//     {
//         cki = Console.ReadKey();
//         if (cki.Key == ConsoleKey.Enter) break;
//         if (cki.Key == ConsoleKey.D0 || cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.D4 || cki.Key == ConsoleKey.D5 ||
//             cki.Key == ConsoleKey.D6 || cki.Key == ConsoleKey.D7 || cki.Key == ConsoleKey.D8 || cki.Key == ConsoleKey.D9) count++;

//     }
//     Console.WriteLine(count);

//     return count;

// }


// Console.WriteLine(Test());