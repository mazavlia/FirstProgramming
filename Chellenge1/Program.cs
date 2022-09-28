//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

Dictionary<int, int> GenerateDicPoli()
{
    Dictionary<int, int> palidrom = new Dictionary<int, int>();

    for (int i = 10; i < 100; i++)
    {
        int polik = (i) * 100 + (i % 10) * 10 + i / 10;
        palidrom.Add(polik,0);
        Console.WriteLine(polik);
    }
    return palidrom;
}

// тест на пятизначность и полиндром Лилия
bool TestPolinHash(int numberP , Dictionary<int, int> dict)
{
    if (dict.ContainsKey(numberP))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// тест на пятизначность и полиндром Лилия
bool TestPolin(int numberP)
{
    if ((numberP / 1000) == (numberP % 100))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метод проверки палиндрома Кирилла
bool PalindromeTest(double a)
{
    char[] charArray = a.ToString().ToCharArray();
    Array.Reverse(charArray); // Тут просто разворачиваем массив
    double reversedArray = double.Parse(charArray);
    if (reversedArray == a) // Проверка на палиндром
    {
        return true;
    }
    else
    {
        return false;
    }

}



int polindrom = ReadData("Введите полиндром:");

Dictionary<int, int> palidromDic = GenerateDicPoli();


DateTime d1 = DateTime.Now;
TestPolin(polindrom);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PalindromeTest(polindrom);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
TestPolinHash(polindrom,palidromDic);
Console.WriteLine(DateTime.Now - d3);