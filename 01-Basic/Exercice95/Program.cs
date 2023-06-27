using System;

/*
Escreva um programa C# para verificar se a string é válida ou não. A string de entrada será válida quando colchetes abertos e colchetes fechados forem do mesmo tipo de colchetes.

Ou
colchetes abertos serão fechados na ordem correta.
Dados de exemplo:
( "<>") -> Verdadeiro
("<>()[]{}") -> Verdadeiro
("(<>") -> Falso
("[<>()[]{}]” ) -> Verdadeiro
*/

namespace Exercice95;

class Program
{
    static void Main(string[] args)
    {
        string input = "(<>";

        bool isValid = CheckValidString(input);
        Console.WriteLine($"A string '{input}' é {(isValid ? "válida" : "inválida")}.");
    }

    static bool CheckValidString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (IsOpeningBracket(c))
            {
                stack.Push(c);
            }
            else if (IsClosingBracket(c))
            {
                if (stack.Count == 0 || !BracketsMatch(stack.Peek(), c))
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }

    static bool IsOpeningBracket(char c)
    {
        return c == '(' || c == '[' || c == '<' || c == '{';
    }

    static bool IsClosingBracket(char c)
    {
        return c == ')' || c == ']' || c == '>' || c == '}';
    }

    static bool BracketsMatch(char opening, char closing)
    {
        return (opening == '(' && closing == ')')
               || (opening == '[' && closing == ']')
               || (opening == '<' && closing == '>')
               || (opening == '{' && closing == '}');
    }
}
