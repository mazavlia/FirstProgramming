// Задача 69.
// Напишите программу, которая на вход принимает 2 числа: a и b 
// Возведите число a в целую степень b с помощью рекурсии.

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

    int RecPow(int A, int B)
    {
        // if (B==1) return A;
        if (B == 0) return 1;
        return A*RecPow(A, B-1);
    }

    int numA = ReadData("Введите число A: ");
    int numB = ReadData("Введите число B: ");
    int resultPow = RecPow(numA, numB);
    PrintResult("Возведение числа A в степень числа B равна: " + resultPow);