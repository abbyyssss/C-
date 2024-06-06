double tempC, tempF;
char r;

do
{
    Console.WriteLine("digite a temperatura em Celcius: ");
    tempC = double.Parse(Console.ReadLine());

    tempF = (tempC * 9.0 / 5.0) + 32.0;
    Console.WriteLine(" a temperatura em fahrenheit é :" + tempF + ".");

    Console.WriteLine(" deseja repetir? (s/n) : ");
    r = char.Parse(Console.ReadLine());
} while (r == 's' || r == 'S');