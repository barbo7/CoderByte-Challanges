/*
Have the function StringChallenge(str) take the str parameter being passed and determine if exactly three unique, single-digit integers occur within each word in the string. The integers can appear anywhere in the word, but they cannot be all adjacent to each other. If every word contains exactly 3 unique integers somewhere within it, then return the string true, otherwise return the string false. For example: if str is "2hell6o3 wor6l7d2" then your program should return "true" but if the string is "hell268o w6or2l4d" then your program should return "false" because all the integers are adjacent to each other in the first word.
*/
using System;

class MainClass {

  public static bool StringChallenge(string str) 
  {
    string[] hop = str.Split(' ');
    bool sonuc = true;

    for(int l=0;l<hop.Length;l++)
    {
      string metin = hop[l],sayilar="";

      for(int i=0;i<metin.Length;i++)
      {
        if(int.TryParse(metin[i].ToString(),out int sayi))
          if(sayilar.Contains(sayi.ToString())==false)
          sayilar+=sayi;
          else
          {
           sonuc=false;
           break;
          }
      }
      if(sayilar.Length !=3)
      sonuc = false;
    }

    return sonuc;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(StringChallenge(Console.ReadLine()));
  } 

}
