// № 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.


int inputNumber = 0;
bool result = false;

// Получаем число от пользователя.
void ReadData()
{
    Console.WriteLine("Введите 5-значное число - палиндром: ");
    string? inputLine = Console.ReadLine()??"";
    inputNumber = int.Parse(inputLine);
}

// Определяем диапазон числа.
void CalculateData()
{
    result = ((inputNumber > 9999) && (inputNumber < 100000));
}

// Выводим данные вычисления.
void PrintData()
{
    if (result)
    {
        char[] charArray = inputNumber.ToString().ToCharArray();
        if ((charArray[0] == charArray[4]) && (charArray[1] == charArray[3]))
        {
            Console.WriteLine("Вы ввели 5-значное число-палиндром.");
        }  
        else 
        {
            Console.WriteLine("Введенное Вами 5-ти значное число не палиндром.");
        }
        
    }
    else
    {
        Console.WriteLine("Вы ввели не 5-значное число.");
    }
}

ReadData();
CalculateData();
PrintData();