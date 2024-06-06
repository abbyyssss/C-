int num, i;
Console.WriteLine("digite um número para ver sua tabuada :");
num = int.Parse(Console.ReadLine());

for (i = 1; i <= 10; i++)
{
    Console.WriteLine(num + " x " + i + "= " + num * i + ".");
}