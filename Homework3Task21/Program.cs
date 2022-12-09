// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// int X1 = ReadData("Введите координату Х1: ");
// int Y1 = ReadData("Введите координату Y1: ");
// int Z1 = ReadData("Введите координату Х2: ");
// int X2 = ReadData("Введите координату Y2: ");
// int Y2 = ReadData("Введите координату Х3: ");
// int Z2 = ReadData("Введите координату Y3: ");

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// //Метод находит расстояние между точками в пространстве
// double DistanceBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
//     return distance;
// } 

// //Метод выводит данные пользователю
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);
// }

// PrintData("Расстояние между точками в пространстве: ", DistanceBetweenPoints(X1, Y1, Z1, X2, Y2, Z2));



// Метод читает данные от пользователя
string ReadData(string msg)
{
    string s = string.Empty;
    Console.WriteLine(msg);
    return s=Console.ReadLine()??"0";

}
//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Метод находит расстояние между точками в пространстве
double DistanceBetweenPoints(string point1, string point2)
{
    string[] coordinates1=point1.Split(new char[] {','});
    string[] coordinates2=point2.Split(new char[] {','});
    double distance = Math.Sqrt(Math.Pow(double.Parse(coordinates1[0]) - double.Parse(coordinates2[0]),2)+
                                Math.Pow(double.Parse(coordinates1[1]) - double.Parse(coordinates2[1]),2)+
                                Math.Pow(double.Parse(coordinates1[2]) - double.Parse(coordinates2[2]),2));
    return distance;
} 

string point1 = ReadData("Введите координаты первой точки в формате: x, y, z");
string point2 = ReadData("Введите координаты первой точки в формате: x, y, z");
PrintData("Расстояние между точками в пространстве: ", DistanceBetweenPoints(point1,point2));
