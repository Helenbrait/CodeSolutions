//my solution

using System;
using System.Data;
// best time in codewars 2371; 
public class Kata
{
  public static int CountBits(int n)
  {
  // n base of 10 number notation
  // change base from 10 to 2
  String nBinary = Convert.ToString(n, 2);
  int SumOne =0; // number of bits that equal 1
  // summarize bits equal 1
  for(int i=0; i<nBinary.Length; i++)
  if (nBinary[i] == '1') SumOne++;
  return SumOne;
  }
}

// best practice solution
/*
using System;
using System.Linq;

public class Kata
{
  public static int CountBits(int n)
  {
    return Convert.ToString(n, 2).Count(x => x == '1');
  }
}
*/
