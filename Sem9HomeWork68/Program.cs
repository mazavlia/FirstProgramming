// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

// Вычисление функции Аккермана с помощью рекурсии
int AccerRec(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AccerRec(m - 1, 1);
    else
      return AccerRec(m - 1, AccerRec(m, n - 1));
}

// Программа вычисления функции.
int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

PrintResult("Функция Аккермана A(m,n) = " + AccerRec(m, n));