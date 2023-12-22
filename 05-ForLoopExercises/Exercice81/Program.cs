 /*
 Escreva um programa C# Sharp para exibir um padrão de alfabeto como X com um asterisco.

 Exiba o padrão como 'X' com um asterisco:                                      
 ---------------------------------------------                                    
                                                                                  
  *    *                                                                           
  *    *                                                                           
   * *                                                                            
    *                                                                             
   * *                                                                            
  *   *                                                                           
  *   *
 */
 
 using System;

 class Program
 {
  static void Main()
  {
   DisplayAlphabetPatternX();
  }

  static void DisplayAlphabetPatternX()
  {
   Console.WriteLine("Exibe o padrão como 'X' com um asterisco:");

   for (int i = 1; i <= 7; i++)
   {
    for (int j = 1; j <= 7; j++)
    {
     if ((i == j || i + j == 8) && (j == 2 || j == 4 || j == 6))
     {
      Console.Write("*");
     }
     else
     {
      Console.Write(" ");
     }
    }
    Console.WriteLine();
   }
  }
 }
