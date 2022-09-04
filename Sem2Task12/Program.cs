//===========================================================================
// № 12 Напишите программу, которая принимаtn на вход 2 числа и выводит, 
// является ли второе число кратным первому. Если второе число кратно первому, 
// то программа выдает остаток от деления.
//===========================================================================

void MyVersion()
{
Console.WriteLine("Введите 2 числа");
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    if (inputNumberA % inputNumberB == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else 
    {
        Console.WriteLine("Второе число не кратно первому, остаток от деления " + inputNumberA % inputNumberB);
    }
}
}