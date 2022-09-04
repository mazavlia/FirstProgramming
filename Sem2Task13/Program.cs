//===========================================================================
// № 13 Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
//===========================================================================

void Method1()
{
Console.WriteLine("Введите любое число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if (inputNumber > 99) 
    {
        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine("Третья цифра введенного Вами числа: "+ charArray[2]);
    }
    else 
    {
        Console.WriteLine("Третьей цифры в введенном Вами числе нет.");
    }
}
}

Method1();