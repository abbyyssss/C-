int b, i, j;
Console.WriteLine("digite a base do triangulo : ");
b = int.Parse(Console.ReadLine());

for (i = 0; i < b; i++)
{
    for (j = 0; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
