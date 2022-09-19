//===================================================================================
// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
// * Найдите площадь треугольника, образованного пересечением 3 прямых
//===================================================================================

// Метод считывания данных пользователя
double ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    double number = double.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

double[] FindPoint(double b1, double b2, double k1, double k2)
{
    double[] outtArr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    outtArr[0] = x;
    outtArr[1] = y;
    return outtArr;
}

double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");
double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");
double[] point = FindPoint(b1, b2, k1, k2);
PrintResult("Точка пересечения 2х прямых: ", $"({point[0]};{point[1]})");
