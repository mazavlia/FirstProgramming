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
    double x1 = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x1 + b1;
    outtArr[0] = x1;
    outtArr[1] = y1;
    return outtArr;
}

//Вводим значения
double b1 = ReadData("Введите значение b1: ");
double b2 = ReadData("Введите значение b2: ");
double b3 = ReadData("Введите значение b3: ");
double k1 = ReadData("Введите значение k1: ");
double k2 = ReadData("Введите значение k2: ");
double k3 = ReadData("Введите значение k3: ");

// Находим координаты точки А
double[] pointA = FindPoint(b1, b2, k1, k2);
PrintResult("Координаты точки А: ", $"({pointA[0]};{pointA[1]})");

// Находим координаты точки В
double[] pointB = FindPoint(b2, b3, k2, k3);
PrintResult("Координаты точки B: ", $"({pointB[0]};{pointB[1]})");

// Находим координаты точки С
double[] pointC = FindPoint(b3, b1, k3, k1);
PrintResult("Координаты точки C: ", $"({pointC[0]};{pointC[1]})");


//Печатаем длину отрезка LineA (с округлением Math.Round,2)
double LineA = Math.Round((Math.Sqrt((Math.Pow((pointB[0] - pointA[0]), 2)) + (Math.Pow((pointB[1] - pointA[1]), 2)))),2);
PrintResult("Длина отрезка А: ", $"{LineA}");

//Печатаем длину отрезка LineВ
double LineB = Math.Round((Math.Sqrt((Math.Pow((pointC[0] - pointB[0]), 2)) + (Math.Pow((pointC[1] - pointB[1]), 2)))),2);
PrintResult("Длина отрезка B: ", $"{LineB}");

//Печатаем длину отрезка LineС
double LineC = Math.Round((Math.Sqrt((Math.Pow((pointA[0] - pointC[0]), 2)) + (Math.Pow((pointA[1] - pointC[1]), 2)))), 2);
PrintResult("Длина отрезка C: ", $"{LineC}");


// Находим площадь треугольника по формуле Герона:
//S = √p(p-a)(p-b)(p-c) - формула площади треугольника, 
// где p - полупериметр, p=(a+b+c)/2

if (LineA + LineB > LineC && LineC + LineB > LineA && LineA + LineC > LineB)
{
    double p = (LineA + LineB + LineC)/2;
    double STrian = Math.Round(Math.Sqrt(p*(p-LineA)*(p-LineB)*(p-LineC)),2);
    PrintResult("Площадь треугольника, образованного тремя отрезками (формула Герона), составляет: ", $"{STrian}");
}
else 
{
    Console.WriteLine("Из текущих данных нельзя построить треугольник: линии параллельны или координаты точек имеют одинаковые значения.");
}