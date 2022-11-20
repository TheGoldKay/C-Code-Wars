using System;
using System.Globalization;
using System.Text.RegularExpressions;

public partial class Kata
    {
        public static string AliasGen(string fName, string lName)
        {
          // class is partial,
          // FirstName and Surname dictionaries are defined in other part of partial
          // you can access them directly here+
          if(Regex.IsMatch(fName[0].ToString(), @"\d") || Regex.IsMatch(lName[0].ToString(), @"\d"))
          {
            return  "Your name must start with a letter from A - Z.";
          }
          string fname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fName.ToLower());
          string lname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lName.ToLower());
          Console.WriteLine(fname);
          string ans = FirstName[fname[0].ToString()] + " " + Surname[lname[0].ToString()]; 
          return ans;
        } 
    }