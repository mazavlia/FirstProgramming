// // Задача №40. Напишите программу, которая принимает на вход три числа
// // и проверяет, может ли существовать треугольник с сторонами такой длины.

// // Метод ввода целых чисел
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "");
//     // Возвращаем значение
//     return number;
// }

// // Метод вывода на печать.
// void PrintResult(bool line)
// {
//     Console.WriteLine(line);
// }

// bool TrlgTest(int a, int b, int c)
// {
//     bool res = false;
//     if ((a+b>c)&&(b+c>a)&& (a+c>b)) res = true;
//     return res;
// }

// int lineA = ReadData("Введите сторону треугольника a: ");
// int lineB = ReadData("Введите сторону треугольника b: ");
// int lineC = ReadData("Введите сторону треугольника c: ");

// bool res = TrlgTest(lineA, lineB, lineC);
// PrintResult(res);



// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

bool TriangleTest(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (b + c > a);
}

int a = ReadData("Введите длину стороны a: ");
int b = ReadData("Введите длину стороны b: ");
int c = ReadData("Введите длину стороны c: ");

PrintResult(TriangleTest(a, b, c) ? "Такой треугольник может быть" : "Такого треугольника не может быть");