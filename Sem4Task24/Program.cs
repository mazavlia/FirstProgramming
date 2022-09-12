//===============================================================
// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int param = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return param;
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("Введите число А: ");
int res1 = VariantSumSimple(numberA);
DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);

int res2 = VariantSumGause(numberA);
DateTime d2 = DateTime.Now;
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна (простой метод): " + res1);
PrintResult("Сумма чисел от 1 до А равна (метод Гаусса): " + res2);

