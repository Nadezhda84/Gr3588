//Первый способ

// int number = int.Parse(Console.ReadLine() ?? "0");

// if (number>0 && number<8)
// {
//     if (number >5) Console.WriteLine("Это выходной день!!!");
//     else Console.WriteLine("Это рабочий день((");
// }
// else Console.WriteLine("Это не день недели!");



//Второй способ

// int number = int.Parse(Console.ReadLine() ?? "0");
// string[] dayOfWeek = new string[7]                                                                                   //Создаем массив
// {
//     "Рабочий день", "Рабочий день", "Рабочий день", "Рабочий день", "Рабочий день", "Выходной", "Выходной"
// };

// if (number>0 && number<8) Console.WriteLine(dayOfWeek[number]);
// else Console.WriteLine("Это не день недели!");



//Третий способ
int number = int.Parse(Console.ReadLine() ?? "0");
Dictionary<int, string> dayOfWeek = new Dictionary<int, string>()                                                       //Создаем коллекцию
{
    [1] = "Рабочий день.",
    [2] = "Рабочий день.",
    [3] = "Рабочий день.",
    [4] = "Рабочий день.",
    [5] = "Рабочий день.",
    [6] = "Выходной!",
    [7] = "Выходной!"
};
if (number>0 && number<8) Console.WriteLine(dayOfWeek[number]);
else Console.WriteLine("Это не день недели!");

