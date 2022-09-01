//===========================================================================
// № 4 Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
//===========================================================================


//Вводим 3 числа
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

//Проверяем, что эти числа не "пустые"
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    //Присваиваем "целое" число (integer)
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    
// Выводим на печать максимум между числом С и (максимумом между числом А и числом В)
    Console.WriteLine(Math.Max(inputNumberC, Math.Max(inputNumberA, inputNumberB)));

}