
//triangle program

using System;
class Triangle {
  static void Main() {
      Console.Write("Enter Height : ");
      int n = int.Parse(Console.ReadLine());
      printTriangle(n);
  }
  
  static void printTriangle(int h) {
      int sp = h-1;
      int stL = 1;
      int stR = 0;
      for(int i=0; i<h; i++) {
          for(int j=0; j<sp; j++) {
              Console.Write(" ");
          }
          for(int j=0; j<stL; j++) {
              Console.Write("*");
          }
          for(int j=0; j<stR; j++) {
              Console.Write("*");
          }
          Console.WriteLine("\n");
          sp--;
          stL++;
          stR++;
      }
  }
}