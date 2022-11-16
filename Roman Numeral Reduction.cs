/*Have the function RomanNumeralReduction(str) read str which will be a string of roman numerals in decreasing order. 
The numerals being used are: I for 1, V for 5, X for 10, L for 50, C for 100, D for 500 and M for 1000. 
Your program should return the same number given by str using a smaller set of roman numerals. 
For example: if str is "LLLXXXVVVV" this is 200, so your program should return CC 
because this is the shortest way to write 200 using the roman numeral system given above. If a string is given in its shortest form, 
just return that same string.*/

using System;
using System.Collections.Generic;
using System.Linq;
class MainClass {

  public static string StringChallenge(string str) {

    // code goes here  
    char[] karakter = str.ToCharArray();
    int toplam = 0;
    Dictionary<string, int> dc = new Dictionary<string, int>();
    dc.Add("M", 1000);
    dc.Add("D", 500);
    dc.Add("C", 100);
    dc.Add("L", 50);
    dc.Add("X", 10);
    dc.Add("V", 5);
    dc.Add("I", 1);

    foreach (var i in karakter)
    toplam += dc[i.ToString()]; 

    string kelime = "";
            
    while(toplam >0)
    {
      foreach(var i in dc)
      {
        if (toplam % i.Value == 0)
        {
          toplam -= i.Value;
          kelime += i.Key;
          break;
        }
      }
    }
    return new string(kelime.Reverse().ToArray());
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(StringChallenge(Console.ReadLine()));
  } 

}
