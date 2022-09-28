// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Сумма натуральных чисел от М до N.
int RecSumMN(int numM, int numN)
{    
int sum = 0;
if (numM >= numN) return numN; 
sum = numM + RecSumMN(numM + 1, numN); 
return sum;
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

PrintResult("Сумма значений от M до N: " + (M > N ? RecSumMN(N, M) : RecSumMN(M, N)));
