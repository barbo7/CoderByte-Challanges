/*Have the function Primes(num) take the num parameter being passed and return the string true if the parameter is a prime number, 
otherwise return the string false. The range will be between 1 and 2^16.*/

using System;

class MainClass {

  public static bool MathChallenge(int num) {

    // code goes here  
    bool sa=true;
    for(int i=2;i<num;i++)
    {
      if(num%i==0)
      sa=false;
    }
    return sa;


  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(MathChallenge(Console.ReadLine()));
  } 

}
