// Inclua nesse programa uma solicitação de nome completo do usuário. A cada impressão do console, deve ser exibido o nome completo do usuário, a mensagem se o usuário é maior, menor ou se possui autorização, e também a idade digitada pelo usuário. Se o usuário tiver até 10 anos, aparecer a mensagem: "você é uma criança". Entre 10 e 14, "você é um pré-adolescente". Entre 15 e 17, "você é um adolescente". Entre 18 e 60, "você é um adulto". Acima dos 60, "você está na melhor idade". Você não deve apagar nenhum código abaixo.

// Solicite o nome completo do usuário.
Console.WriteLine("Digite o seu nome completo: ");
string nome = Console.ReadLine();

// Solicitar a idade.
Console.WriteLine("Digite a sua idade");
int idade = int.Parse(Console.ReadLine());

// Verificar se o usuário é maior ou menor de idade.
if (idade >= 18)
{
    Console.WriteLine($"{nome}, você tem {idade} anos e é maior de idade.");
}
else if (idade >= 16)
{
    Console.WriteLine($"{nome}, você tem {idade} anos e poderá entrar caso tenha uma autorização dos responsáveis.");
}

else
{
    Console.WriteLine($"{nome}, você tem {idade} anos e é menor de idade.");
}

// Se o usuário tiver até 10 anos, aparecer a mensagem: "você é uma criança". Entre 10 e 14, "você é um pré-adolescente". Entre 15 e 17, "você é um adolescente". Entre 18 e 60, "você é um adulto". Acima dos 60, "você está na melhor idade". Você não deve apagar nenhum código abaixo.
if (idade <= 10)
{
    Console.WriteLine("Você também é uma criança.");
}

else if (idade <= 14)
    {
    Console.WriteLine($"Você também é um pré-adolescente.");
}

else if (idade <= 17)
{
    Console.WriteLine($"Você também é um adolescente.");
}

else if (idade <= 60)
{
    Console.WriteLine($"Você também é um adulto.");
}

else
{
    Console.WriteLine($"Você está na melhor idade.");
}


