using System;
using System.Linq;

// Preloaded method Tools.FromCharCode(int i) available!

public class Kata
{
  public static string ArrowFunc(int[] arr)
  {
    string x = "";
    foreach (char item in arr)
    {
        x += item;
    }
    return x;
  }
}
Console.WriteLine(Kata.ArrowFunc({84,101,115,116}));