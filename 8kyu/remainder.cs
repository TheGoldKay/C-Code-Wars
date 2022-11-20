using System;

public class Kata
{
  public static int Remainder(int a, int b)
  {
    if(a > b)
    {
        return a%b;
    }else 
    {
        return b%a;
    }
  }
}