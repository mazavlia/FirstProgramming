//===========================================================================
// № 14 Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//===========================================================================

int inputNumber = 0;
bool result = false;

// Получаем число от пользователя.

void ReadData()
{
    Console.WriteLine("Введите число: ");
    string? inputLine = (Console.ReadLine()??"");
    inputNumber = int.Parse(inputLine);
}

// Определяем кратность чисел.
void CalculateData()
{
    result = (inputNumber % 7 == 0 && inputNumber % 23 == 0);
}

// Выводим данные вычисления.
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Введенное число кратно одновременно 7 и 23.");
    }
    else
    {
        Console.WriteLine("Введенное число не кратно одновременно 7 и 23.");
    }
}

ReadData();
CalculateData();
PrintData();
