//===========================================================================
// № 15 Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
//===========================================================================

int inputDayOfWeek = 0;
string outDayOfWeek = string.Empty;
// bool result = false;

// Получаем число от пользователя.
void ReadData()
{
    Console.WriteLine("Введите цифру, обозначающую день недели: ");
    string? inputLine = Console.ReadLine()??"";
    inputDayOfWeek = int.Parse(inputLine);
}

// Определяем параметры числа
void ParamData()
{
switch (inputDayOfWeek)
    {
        case 1: outDayOfWeek = "Понедельник - будний день"; break;
        case 2: outDayOfWeek = "Вторник - будний день"; break;
        case 3: outDayOfWeek = "Среда - будний день"; break;
        case 4: outDayOfWeek = "Четверг - будний день"; break;
        case 5: outDayOfWeek = "Пятница - будний день"; break;
        case 6: outDayOfWeek = "Суббота - выходной день"; break;
        case 7: outDayOfWeek = "Воскресенье - выходной день"; break;
        default: outDayOfWeek = "Такого дня недели не существует."; break;
    }
}

// Выводим результат.
void PrintData()
{
    Console.WriteLine(outDayOfWeek);
}

ReadData();
ParamData();
PrintData();

void ShortResult()
{
    Console.WriteLine("Введите цифру, обозначающую день недели: ");
    string? inputLine = Console.ReadLine();
    int inputDayOfWeek = int.Parse((inputLine)??"");

    if (inputDayOfWeek > 0 && inputDayOfWeek < 8)
    {
        Console.WriteLine(
            (inputDayOfWeek == 6 || inputDayOfWeek == 7) ? ("Выходной день.") : ("Будний день.")
        );
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует.");
    }
}

ShortResult();