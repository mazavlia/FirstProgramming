//===========================================================================
// № 9 Напишите программу, которая выводит случайные числа из отрезка 
// [10, 99] и показывает наибольшую цифру числа.
//===========================================================================

void MyVariant()

{
    Console.WriteLine("Method 1");
    System.Random numberGenerator = new System.Random();

    // Генератор случайных чисел от 10 (включая 10) до 100 (т.е. меньше 100, последнее число - 99)
    int number = numberGenerator.Next(10, 100);

    //Выводим на печать сгенерированное число.
    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Вариант 1. Сравнение чисел.
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void mathMaxMethod()

{
    Console.WriteLine("Method 2");
    // Выводим на печать максимальное число из 2х значений методом Math.Max.
    System.Random numberGenerator = new System.Random();

    // Генератор случайных чисел от 10 (включая 10) до 100 (т.е. меньше 100, последнее число - 99)
    int number = numberGenerator.Next(10, 100);

    //Выводим на печать сгенерированное число.
    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine(Math.Max(firstDigit, secondDigit));
}

void ternOperatorMethod()

{
    Console.WriteLine("Method 3");
    System.Random numberGenerator = new System.Random();

    // Генератор случайных чисел от 10 (включая 10) до 100 (т.е. меньше 100, последнее число - 99)
    int number = numberGenerator.Next(10, 100);

    //Выводим на печать сгенерированное число.
    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    // Выводим на печать максимальное число из 2х значений методом тернарного оператора.
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void charMethod()
{
    Console.WriteLine("Method 4");
    System.Random numberGenerator = new System.Random();

    // Генератор случайных чисел от 10 (включая 10) до 100 (т.е. меньше 100, последнее число - 99)
    int number = numberGenerator.Next(10, 100);

    //Выводим на печать сгенерированное число.
    Console.WriteLine(number);

        //Вариант char.
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

MyVariant();
mathMaxMethod();
ternOperatorMethod();
charMethod();