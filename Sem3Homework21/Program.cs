// №21  Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.


int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int param = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return param;
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, который возвращает длину отрезка.
double Calculate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2)));
}

// Соберем данные
int x1 = ReadData("Введите x1 ");
int y1 = ReadData("Введите y1 ");
int z1 = ReadData("Введите z1 ");
int x2 = ReadData("Введите x2 ");
int y2 = ReadData("Введите y2 ");
int z2 = ReadData("Введите z2 ");

// Выводим на печать
double result = Calculate(x1, y1, z1, x2, y2, z2);
PrintResult("Расстояние между точками: " + Math.Round(result, 2));
