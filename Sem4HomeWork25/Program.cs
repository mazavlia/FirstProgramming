//=====================================================================================
// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//=====================================================================================
// * Написать калькулятор с операциями +, -, /, * и возведение в степень
//=====================================================================================

//Метод получения данных от пользователя.
int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int inputNumber = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return inputNumber;
}

// 1 способ решения: умножение числа А количество В раз.
long Pow(int numA, int numB)
{
    long res = 1;
    for (int i = 0; i <numB; i++)
    {
        res = res * numA;
    }
    return res;
}

// 2 способ решения: с помощью математической функции Math.Pow
double MathPow(int numA, int numB)
{
    return Math.Pow(numA, numB);
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число В: ");

PrintResult("1 способ: " + Pow(numA, numB));
DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);

PrintResult("2 способ: " + MathPow(numA, numB));
DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);