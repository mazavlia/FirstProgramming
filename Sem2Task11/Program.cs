//===========================================================================
// № 11 Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
//===========================================================================

void MyVariant()
{
    Console.WriteLine("MyVariant: ");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
    int numberA = number / 100;
    int numberB = number % 10;
    Console.Write(numberA);
    Console.WriteLine(numberB);
}

void MyVariant2()
{
    Console.WriteLine("MyVariant2: ");
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine(number);
int numberA = number / 100;
int numberB = number % 10;
Console.WriteLine(numberA * 10 + numberB);
}

void charVariant()
{ 
Console.WriteLine("charVariant: ");    
System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(100, 1000);
Console.WriteLine(number);

// Переводим в массив и выводим на печать [0] и [2] значение массива.
char[] charArray = number.ToString().ToCharArray();
Console.WriteLine(""+ charArray[0] + charArray[2]);
}

MyVariant();
MyVariant2();
charVariant();
