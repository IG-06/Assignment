//string
using System;
using System.Text.RegularExpressions;


class CheckValidDate {
  public static void Main() {
      Console.Write("Enter string : ");
      string s = Console.ReadLine();
      validDate(s);
  }
  
  public static void validDate(string s) {
      string[] arr = s.Split(' ');
      
      foreach(string a in arr)
      {
          if ((a.Length == 8) && (Regex.IsMatch(a, @"^\d+$")))
          {
              int n = int.Parse(a);
              if(n/1000000 >= 1 && n/1000000 <= 12)
              {
                  n = n%1000000;
              }
              else
              {
                  break;
              }
              
              if(n/10000 >= 1 && n/10000 <= 31)
              {
                  n = n%10000;
              }
              else
              {
                  break;
              }
            
            Console.WriteLine("Valid Date : "+ a);
          }
      }
      
  }
}