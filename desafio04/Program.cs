/* Se o usuário tiver até 10 anos aparecer a mensagem "você é uma criança", entre 10 e 14 "você é um pré-adolescente", entre 15 e 17 "você é um adolescente", entre 18 e 60 "você é um adulto" maiores que 60 "você está na melhor idade". Você não deve apagar nenhum código abaixo
*/

Console.WriteLine("Digite seu nome:");

string nome = Console.ReadLine();

Console.WriteLine("Qual o sua idade?");

double idade = double.Parse(Console.ReadLine());

if (idade >= 18)

{
    Console.WriteLine($" {nome}, você é maior de idade {idade}");

}

else if (idade >= 16)

{
    Console.WriteLine($" {nome}, você pode entrar com autorização {idade}");

}

else

{

    Console.WriteLine($" {nome}, você é menor de idade {idade} ");

}
if (idade <= 10)
{
    Console.WriteLine($" {nome}, você é uma criança. ");

}
else if (idade <= 14)
    Console.WriteLine($"{nome}, você é um pré-adolescente. ");

 else if (idade >= 17)
{
    Console.WriteLine($"{nome}, você é um adolescente. ");
}
