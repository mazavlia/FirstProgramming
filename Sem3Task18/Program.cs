// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

// Чтение данных из консоли (метод общения с пользователем)
int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return number;
}

// Метод, который возвращает номер четверти.
string QuarterBoarderAsk(int numQuarter)
{
    if (numQuarter == 1)
        return "x>0 y>0";
    if (numQuarter == 2)
        return "x<0 y>0";
    if (numQuarter == 3)
        return "x<0 y<0";
    if (numQuarter == 4)
        return "x>0 y<0";

    return "Вне четверти";
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res = QuarterBoarderAsk(num);

PrintResult(res);
