using System;

public class Kata
{
  public static string Shortcut(string input)
  {
    string v = "aAeEiIoOuU";
	  string news = "";
    foreach(char c in input){
      if(!v.Contains(Char.ToString(c))){
        news += c;			
      }
	}
	return news;  
  }
}