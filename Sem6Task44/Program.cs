// Задача №44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

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
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

string FibNum(int num)
{
    string res = string.Empty;
    int first = 0;
    int last = 1;
    int buf = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + " " + first;
        buf = first + last;
        first = last;
        last = buf;
    }
    return res;
}

// int numFib = ReadData("Введите количество чисел фибоначчи: ");
// string line = FibNum(numFib);
// PrintResult("Числа фибоначчи: ", line);

PrintResult("Числа фибоначчи: ", FibNum(ReadData("Введите количество чисел фибоначчи: ")));