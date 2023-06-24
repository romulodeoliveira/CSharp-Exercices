/*
Escreva um programa C# Sharp para encontrar o próximo número primo de um determinado número. Se o número fornecido for um número primo, retorne o número.

da Wikipédia:
Um número primo (ou primo) é um número natural maior que 1 que não é um produto de dois números naturais menores. Um número natural maior que 1 que não é primo é chamado de número composto. Por exemplo, 5 é primo porque as únicas formas de escrevê-lo como um produto, 1 × 5 ou 5 × 1, envolvem o próprio 5. No entanto, 4 é composto porque é um produto (2 × 2) no qual ambos os números são menores que 4. Os primos são centrais na teoria dos números por causa do teorema fundamental da aritmética: todo número natural maior que 1 é um primo em si ou pode ser fatorado como um produto de primos que é único até sua ordem.

Saída de amostra:

Número original: 120
Próximo número primo/Número primo atual: 127
Número original: 321
Próximo número primo/Número primo atual: 331
Número original: 43
Próximo número primo/Atual número primo: 43
Número original: 4433
Próximo número primo/Atual número primo: 4441
*/

namespace Exercice92;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int input = Convert.ToInt32(Console.ReadLine());

        int nextPrimeNumber = input;

        while (!Number.IsPrime(nextPrimeNumber))
        {
            nextPrimeNumber++;
        }

        Console.WriteLine($"{input} - {nextPrimeNumber}");
    }
}

