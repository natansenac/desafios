// Escreva um programa que solicita a um usuário a quantidade em litros abastecidos em um automóvel. Em seguida, o programa deve solicitar que o usuário informe a quantidade de quilômetros percorridos até o término do tanque. O programa deve exibir a quantidade de quilômetros por litro.


// Solicitar a quantidade de litros abastecidos
Console.WriteLine("Quantidade de litros abastecidos");
double litrosAbestecidos = double.Parse(Console.ReadLine());

// Solicitar a quantidade de quilômetros percorridos
Console.WriteLine("Quantidade de quilômetros percorridos");
double kmPercorridos = double.Parse(Console.ReadLine());

// Calcular a quantidade de quilômetros por litro
double kmPorLitro = kmPercorridos / litrosAbestecidos;

// Resultado
Console.WriteLine($"O consumo do automóvel é de {kmPorLitro} quilômetros por litro");