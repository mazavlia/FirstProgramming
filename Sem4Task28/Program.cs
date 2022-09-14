//==========================================================
// Задача №28 Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120
//==========================================================

//Метод получения данных от пользователя.
int ReadData(string line)
{
    // Выводим сообщение.
    Console.WriteLine(line);
    //Считываем число.
    int inputNumber = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение.
    return inputNumber;
}

// Метод вычисления 1
long CalculateFactorial(int numA)
{
    long factorial = 1;
    for (int i = 1; i <= numA; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

// Метод вычисления 2
long CalcData(int numA)
{
    if (numA == 1)
        return 1;
    return numA * CalcData(numA - 1);
}

// Метод вывода на печать.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число A: ");

long factorial = CalculateFactorial(num);
PrintResult("Факториал равен: " + factorial);

long factorialRecursy = CalcData(16);
PrintResult("(Рекурсия) факториал равен: " + factorialRecursy);
