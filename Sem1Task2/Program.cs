//===========================================================================
// № 2 Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//===========================================================================

// Вводим 2 числа.
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

// Проверяем, что эти числа не "пустые".
if (inputLineA != null && inputLineB != null)
{
    // Присваиваем введенному значению "целое" число (integer).
    int inputA = int.Parse(inputLineA);
    int inputB = int.Parse(inputLineB);
    
    // Сравниваем числа между собой.

        if (inputA == inputB)
    {
        Console.WriteLine("Числа между собой равны");
    }
    else
    {
        if (inputA > inputB)
        {
            Console.WriteLine(inputA + " > " + inputB);
        }
        else
        {
            Console.WriteLine(inputB + " > " + inputA);
        }
    }
}