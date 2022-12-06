// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// Console.WriteLine("Введите х: ");
// int x = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите y: ");
// int y = int.Parse(Console.ReadLine() ?? "0");

// if (x>0)
// {
//     if (y>0) Console.WriteLine("Это первая четверть");
//     else  Console.WriteLine("Это вторая четверть");
// }
// else
// {
//     if (y>0) Console.WriteLine("Это четвертая четверть");
//     else  Console.WriteLine("Это третья четверть");
// }




int x = ReadData("Введите х: ");
int y = ReadData("Введите y: ");
PrintQuterTest();

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяет четверть по координатам точки
void PrintQuterTest()
{
    if (x>0&& y>0) Console.WriteLine("Это первая четверть");
    if (x>0&& y<0) Console.WriteLine("Это вторая четверть");
    if (x<0&& y<0) Console.WriteLine("Это третья четверть");
    if (x<0&& y>0) Console.WriteLine("Это четвертая четверть");

}
