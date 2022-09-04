//===========================================================================
// № 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
//===========================================================================

void Method1()
{
Console.WriteLine("Введите любое трехзначное число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if (inputNumber > 99 && inputNumber < 1000) 
    {
        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine("Вторая цифра введенного Вами числа: "+ charArray[1]);
    }
   
    else 
    {
        Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз.");
    }
}
}