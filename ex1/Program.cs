int dividendo, divisor, quociente, resto;
Console.WriteLine("digite o dividendo :");
dividendo = int.Parse(Console.ReadLine());
Console.WriteLine("escreva o divisor:");
divisor = int.Parse(Console.ReadLine());

quociente = dividendo / divisor;
resto = dividendo % divisor;

Console.WriteLine("seu dividendo é :" + dividendo +".");
Console.WriteLine("seu divisor é :" + divisor + ".");
Console.WriteLine(" seu quociente é :" + quociente + ".");
Console.WriteLine(" o resto é :" +resto+ ".");
