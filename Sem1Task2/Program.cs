//===========================================================================
// № 2 Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//===========================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputA = int.Parse(inputLineA);
    int inputB = int.Parse(inputLineB);
    
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