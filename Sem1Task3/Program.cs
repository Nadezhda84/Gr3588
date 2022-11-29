
string? inputLine = Console.ReadLine();

//Создаем массив с днями недели
string[] dayWeek = new string[7];
dayWeek[0] = "Понедельник";
dayWeek[1] = "Вторник";
dayWeek[2] = "Среда";
dayWeek[3] = "Четверг";
dayWeek[4] = "Пятница";
dayWeek[5] = "Суббота";
dayWeek[6] = "Воскресенье";


if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    Console.WriteLine(dayWeek[inputNumber-1]);
}