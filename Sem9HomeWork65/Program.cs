// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// Чтение данных из консоли.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

// Печать результата.
void PrintResult(string line)
{
    Console.WriteLine(line);
}


// Cтрока натуральных чисел от M до N.
string RecMN(int numM, int numN)
{    
if (numM >= numN) return numN.ToString(); 
return numM + " " + RecMN(numM + 1, numN);    
}

// Описание программы.
int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

PrintResult("Строка значений в промежутке от M до N: " + (M > N ? RecMN(N, M) : RecMN(M, N)));
