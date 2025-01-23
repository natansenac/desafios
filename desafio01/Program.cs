// escreva um programa que solicite o primeiro nome do usuário e em seguida, o sobrenome. O programa deve apresentar uma mensagem de boas-vindas e o nome completo do usuário.

// Solicite o primeiro nome

using System.Runtime.CompilerServices;

Console.WriteLine("Digite o seu primeiro nome: ");
string nome = Console.ReadLine();

// Solicite o sobrenome

Console.WriteLine("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

// Mensagem de boas-vindas

Console.WriteLine($"Bem-vindo, {nome} {sobrenome}!");