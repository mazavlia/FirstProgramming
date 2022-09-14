// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.


int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int inputNumber = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return inputNumber;
}

// Метод %10, /10
int DigitCount(int num)
{
    int sum = 0; 
    while(num> 0)
{
    sum+=1;
    num = num / 10;
}
    return sum;
}

// Метод с использованием логарифмов

int CalculateDigits(int number)
{
    return (int)(Math.Log10(number) + 1);
}

// Вариант с длиной строки.
int CalculateDigit(int num3)
{
    string numString = num3.ToString();
    return numString.Length;
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Печать метода %10, /10.
int num = ReadData("Введите число: ");
int res = DigitCount(num);
PrintResult("Количество цифр в числе: " + res);
DateTime d = DateTime.Now;
Console.WriteLine(DateTime.Now - d);

// Печать метода с использованием логарифма.

int num2 = ReadData("Введите число: ");
int res2 = CalculateDigits(num2);
PrintResult("Количество цифр в числе: " + res2);
DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);

// Печать метода длины строки
int num3 = ReadData("Введите число: ");
int res3 = CalculateDigit(num3);
PrintResult("Количество цифр в числе: " + res3);
DateTime d3 = DateTime.Now;
Console.WriteLine(DateTime.Now - d3);



