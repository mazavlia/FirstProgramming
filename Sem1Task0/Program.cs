﻿//===========================================================================
// № 0 Напишите программу, которая на вход принимает число и выдает его 
// квадрат (число, умноженное само на себя)
//===========================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = (int)Math.Pow(inputNumber, 2);
    Console.WriteLine(outNumber);

}