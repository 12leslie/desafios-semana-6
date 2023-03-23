
using System;

string[,] totito = new string[3, 3]
{
    {"","",""},
    {"","",""},
    {"","",""}
};
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Ingrese un dato (x, o): ");
        totito[i, j] = Console.ReadLine();
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("");
    for (int j = 0; j < 3; j++)
    {
        Console.Write(totito[i, j] + " ");
    }
}