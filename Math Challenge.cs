/*
Have the function MathChallenge(num1,num2) take both parameters being passed and return the Greatest Common Factor. 
That is, return the greatest number that evenly goes into both numbers with no remainder. 
For example: 12 and 16 both are divisible by 1, 2, and 4 so the output should be 4. 
The range for both parameters will be from 1 to 10^3.
*/
using System;
using System.Collections;

class MainClass {

  public static int MathChallenge(int num1, int num2) {
    int sonuc = 0;

    // code goes here  
    if(num1 >= num2)
    {    
      for(int i=1;i<=num1;i++)
      {
      if(num1%i==0 && num2%i==0) 
      sonuc=i; 
      }

    }
    else
    for(int k=1;k<num2;k++)
    {
    if(num2%k==0 && num1%k==0)
    sonuc=k; 
    }
    

    return sonuc;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(MathChallenge(Console.ReadLine()));
  } 

}
