using System;

/*
Escreva um programa C# Sharp para converter todos os valores de uma determinada matriz de valores mistos em valores de string.

Exemplo de saída:
Imprimindo os elementos do array original e seus tipos:
Valor-> 25 :: Tipo-> System.Int32
Valor-> Anna :: Tipo-> System.String
Valor-> Falso :: Tipo-> Sistema. Boolean
Value-> 4/15/2021 10:37:47 AM :: Type-> System.DateTime
Value-> 112.22 :: Type-> System.Double
Imprimindo elementos da matriz e seus tipos:
Value-> 25 :: Type- > System.String
Value-> Anna :: Type-> System.String
Value-> False :: Type-> System.String
Value-> 4/15/2021 10:37:47 AM :: Type-> System.String
Valor-> 112,22 :: Tipo-> System.String
*/

namespace Exercice80;

class Program
{
    static void Main(string[] args)
    {
        object[] objectsArray = { 25, "Anna", false, DateTime.Parse("4/15/2021 10:37:47 AM"), 112.22 };

        for (int i = 0; i < objectsArray.Length; i++)
        {
            Console.WriteLine($"{objectsArray[i]} -> {objectsArray[i].GetType()}");
        }

        Console.WriteLine(new string('-', 50));
        
        for (int i = 0; i < objectsArray.Length; i++)
        {
            Console.WriteLine($"{objectsArray[i]} -> {objectsArray[i].ToString().GetType()}");
        }
    }
}