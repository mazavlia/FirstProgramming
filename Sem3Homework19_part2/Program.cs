// № 19*. Напишите программу, которая принимает на вход любое число и проверяет,
// является ли оно палиндромом.


int inputNumber = 0;

// Получаем число от пользователя.

Console.WriteLine("Введите любое число, а мы проверим, является ли оно палиндромом: ");
string? inputLine = Console.ReadLine() ?? "";
inputNumber = int.Parse(inputLine);

// Переводим данные строки в массив
char[] charArray = inputNumber.ToString().ToCharArray();

// Назначаем переменные
int indexN2 = (charArray.Length - 1);
int indexN1 = 0;

for (; ((indexN1 != indexN2) || (indexN1 != (indexN2 - 1))); )
{
    if ((charArray[indexN1] == charArray[indexN2]))
    {
        for (; ((indexN1 == indexN2) || (indexN1 == (indexN2 - 1))); )
        {
            Console.WriteLine("Введенное число является палиндромом.");
            break;
        }
        indexN1++;
        indexN2--;
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
        break;
    }
}
