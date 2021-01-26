/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class CalculaTamanho {
  static void Main() 
  {
    int totalElements = 0;
    string sValue;  
    Console.WriteLine("Por favor Informe uma string: ");
    sValue = Console.ReadLine();
    foreach (char i in sValue)
    {
      totalElements ++;
    }
    Console.WriteLine("Total de elementos: {0}" , totalElements);
    
  }
}
