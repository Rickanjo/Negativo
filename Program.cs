// Leia um número inteiro e exiba a mensagem "Você digitou um número negativo." caso o número seja menor que zero.
Console.WriteLine("--- Negativo ---\n");

Console.Write("Digite um número inteiro:");
int numero = int.Parse(Console.ReadLine()!);

if (numero < 0) {
    Console.WriteLine("Você digitou um número negativo.");
}
