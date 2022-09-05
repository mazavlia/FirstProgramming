//===========================================================================
// № 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//===========================================================================

int inputNumber = 0;
bool result = false;

// Получаем число от пользователя.
void ReadData()
{
    Console.WriteLine("Введите любое трехзначное число: ");
    string? inputLine = Console.ReadLine();
    inputNumber = int.Parse(inputLine);
}

// Определяем диапазон чисел.
void CalculateData()
{
    result = (inputNumber > 99 && inputNumber < 1000);
}

// Выводим данные вычисления.
void PrintData()
{
    if (result)
    {
        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine("Вторая цифра введенного Вами числа: " + charArray[1]);
    }
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число.");
    }
}

ReadData();
CalculateData();
PrintData();