/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class PrintMain
{


  static void Main ()
  {
    int[] nValue3 =
      new int[33] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45,48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93, 96, 99 };
    int[] nValue5 =
      new int[20] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75,80, 85, 90, 95, 100 };
    string cPrint = null;

    for (int i = 0; i <= 100; i++)
      {
	for (int x = 0; x < 33; x++)
	  {
	    if (i == nValue3[x])
	      {
		cPrint = "Foo";
	      }

	    for (int y = 0; y < 20; y++)
	      {

		if (String.IsNullOrEmpty (cPrint))
		  {
		    if (i == nValue5[y])
		      {
			cPrint = "Baa";
		      }
		  }
		else
		  {
		    if (i == nValue5[y] & i == nValue3[x])
		      {
			cPrint = "FooBaa";
		      }
		  }

	      }
	  }
	if (String.IsNullOrEmpty (cPrint))
	  {
	    Console.WriteLine (i);
	    cPrint = null;
	  }
	else
	  {
	    Console.WriteLine (cPrint);
	    cPrint = null;
	  }
      }
  }
}
