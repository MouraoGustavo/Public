/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;

class StringManipulator {
  
  
  static void Main() {
   
  bool   match;      
  //char[] chars = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};  




// STRING INICIAL
  Console.WriteLine("Por favor Digite a string incial: ");
  string  sInicial = Console.ReadLine();
  
 /* for(int i = 0; i < sInicial.Length;i++)
  {
      
  }
 */ 
  
  if(sInicial.Length<=100)
  {
    /*
    for (int i = 0; i < sInicial.Length; i++)
    {
    s[i] = sInicial[i].ToString();
    Console.WriteLine("Funciona");
    }
    */
  } 
  else
  {
    Console.WriteLine("Tamanho de String Inicial Invalido!");
    StringManipulator.Main();
  }
 
 
// STRING DESEJADA
  Console.WriteLine("Por favor Digite a string desejada: ");
  string  sDesejada = Console.ReadLine();
  
  if(sDesejada.Length<=100)
  {
    /*
    for (int i = 0; i < sDesejada.Length; i++)
     {
     t[i] = sDesejada[i].ToString();
     Console.WriteLine("Funciona");
     }
    */
  } 
  else
  {
    Console.WriteLine("Tamanho de String desejada Invalido!");
    StringManipulator.Main();
  }
  
// NUMERO DE OPERACOES
  Console.WriteLine("Por favor Digite o numero de operações: ");
  int nOperaçoes = Convert.ToInt32(Console.ReadLine());
  if(nOperaçoes<=100)
  {
    match = StringManipulator.ConcatERemove(sInicial,sDesejada,nOperaçoes);
    if(match)
    {
       Console.WriteLine("Sim!"); 
    }
    else
    {
       Console.WriteLine("Não!"); 
    }
  } 
  else
  {
    Console.WriteLine("Numero de operações Invalido!");
    StringManipulator.Main();
   
  }
  
  
  
  /*
  switch (option)
  {
    case 1:
        while (a<=100)
        {
        Console.WriteLine("Por favor informe o Caractere a ser concatenado: ");
        s[a] = Console.ReadLine();
        for(int i = 0;i <26; i++)
        {
          if(s[a]==chars[i].ToString())
          {
            match = true;   
          }
        
        }
        
        if(match)
        {
         Console.WriteLine("Valor Informado valido!");   
        }
        else
        {
         Console.WriteLine("Valor informado invalido!");
         s[a] = null;
        }
        //chars[0] = Console.ReadKey().KeyChar;
        //Console.WriteLine("Valor informado char: {0}" , chars[0]);
        a++;
        }
        break;
        
        
    case 2:
        Console.WriteLine("Remover");
        break;
    default:
        Console.WriteLine("Opção invalida,retornando ao menu inicial.");
        StringManipulator.Main();
        break;
    }*/
  
  }
  
  public static bool  ConcatERemove(string param1,string param2,int param3)
  {
      
      List<char> listInicial = new List<char>(); 
      List<char> listDesejada = new List<char>(); 
      string [] validChars = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
      
      for (int i = 0 ; i < param1.Length ; i++)
      {
       listInicial.Add(param1[i]) ;
       Console.WriteLine("Lista Inicial Posição {0} Valor : {1}",i,listInicial[i]);
      }
      
      bool confere = Array.Exists(validChars,element => element == param1);
      Console.WriteLine("Confere?: {0}",confere);
      
      
      for (int i = 0 ; i < param2.Length ; i++)
      {
       listDesejada.Add(param2[i]) ;  
       Console.WriteLine("Lista Desejada Posição {0} Valor : {1}",i,listDesejada[i]);
      }
       
     
      /*
      for (int i = 1 ; i < param1.Length ; i++)
      {
       listInicial.Remove(param1[i]) ;  
      }
      */
      
     
      return true;
  }
  
  
 
}


