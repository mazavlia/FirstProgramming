//===========================================================================
// № 13 Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
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

// Определяем диапазон числа.
void CalculateData()
{
    result = (inputNumber > 99);
}

// Выводим данные вычисления.
void PrintData()
{
    if (result)
    {
        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine("Третья цифра введенного Вами числа: "+ charArray[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры в введенном Вами числе нет.");
    }
}

ReadData();
CalculateData();
PrintData();