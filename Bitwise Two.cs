/*Have the function BitwiseTwo(strArr) take the array of strings stored in strArr, 
which will only contain two strings of equal length that represent binary numbers, 
and return a final binary string that performed the bitwise AND operation on both strings. 
A bitwise AND operation places a 1 in the new string where there is a 1 in both locations in the binary strings, 
otherwise it places a 0 in that spot. For example: if strArr is ["10111", "01101"] then your program should return the string "00101"*/

using System;

class MainClass {

  public static string ArrayChallenge(string[] strArr) {

    // code goes here  
    int a =strArr[0].Length;
    string b ="";
  for(int i=0;i<a;i++)
  {
    if(strArr[0][i] == strArr[1][i]) b+=strArr[0][i];
    else if(strArr[0][i] != strArr[1][i]) b+=0;
  }
  return b;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}
