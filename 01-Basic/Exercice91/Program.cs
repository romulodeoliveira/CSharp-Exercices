using System;

/*
Escreva um programa C# Sharp para remover todos os valores, exceto valores inteiros, de um determinado array de valores mistos.

Exemplo de saída:
Elementos originais do array:
25 Anna False 24/04/2021 11:43:11 AM -112 -34.67
Depois de remover todos os valores, exceto valores inteiros, do referido array de valores mistos: 25 -112
*/

namespace Exercice91;

class Program
{
    static void Main(string[] args)
    {
        object[] objArray = new object[] { 25, "Anna", false, DateTime.ParseExact("24/04/2021 11:43:11 AM", "dd/MM/yyyy hh:mm:ss tt", null), -112, -34.67 };
        
        List<object> objList = objArray.ToList();
        for (int i = objList.Count - 1; i >= 0; i--)
        {
            if (objList[i] is int)
            {
                objList.Remove(objList[i]);
            }
        }

        objArray = objList.ToArray();
        for (int i = 0; i < objArray.Length; i++)
        {
            Console.Write($"{objArray[i]} ");
        }
    }
}
