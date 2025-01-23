// Adapte o programa abaixo para solicitar a idade do usuário. Se o usuário for maior de 18 anos, exibir a mensagem "maior de idade". Do contrário, exibir a mensagem "menor de idade".

// Solicitar a idade.

using System.Runtime.CompilerServices;

Console.WriteLine("Digite a sua idade");
int idade = int.Parse(Console.ReadLine());

// Verificar se o usuário é maior ou menor de idade.

if (idade >= 18)
{
    Console.WriteLine($"O usuário é maior de idade.");
}
else if (idade >= 16)
{
    Console.WriteLine($"O usuário poderá entrar caso tenha uma autorização dos responsáveis.");
}

else
{
    Console.WriteLine($"O usuário é menor de idade.");
}

