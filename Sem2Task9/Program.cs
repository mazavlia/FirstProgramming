//===========================================================================
// № 9 Напишите программу, которая выводит случайные числа из отрезка 
// [10, 99] и показывает наибольшую цифру числа.
//===========================================================================

System.Random numberGenerator = new System.Random();

// Генератор случайных чисел от 10 (включая 10) до 100 (т.е. меньше 100, последнее число - 99)
int number = numberGenerator.Next(10, 100);

//Выводим на печать сгенерированное число.
Console.WriteLine(number);

int firstDigit = number / 10;
int secondDigit = number % 10;

// Выводим на печать максимальное число из 2х значений методом Math.Max.
Console.WriteLine(Math.Max(firstDigit, secondDigit));

// Выводим на печать максимальное число из 2х значений методом тернарного оператора.
Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);

//Вариант char.
char[] charArray = number.ToString().ToCharArray();
Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);

