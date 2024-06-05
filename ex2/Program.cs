using System.ComponentModel.Design;

int idade;

Console.WriteLine("Insira sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade < 16){
    Console.WriteLine("Não eleitor(abaixo de 16 anos)");
   } 
else if (idade >= 18 && idade <= 65){
        Console.WriteLine("Eleitor obrigatório ( entre 18 e 65 anos)");
     }
else if (idade > 65){
    Console.WriteLine("Eleitor facultativo (maior do que 65 anos)");
}
       
     
