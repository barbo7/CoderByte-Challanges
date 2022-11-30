/*
Have the function ArrayRotation(arr) take the arr parameter being passed which will be an array of non-negative integers 
and circularly rotate the array starting from the Nth element where N is equal to the first integer in the array. 
For example: if arr is [2, 3, 4, 1, 6, 10] then your program should rotate the array starting from the 2nd position 
because the first element in the array is 2. The final array will therefore be [4, 1, 6, 10, 2, 3], and 
your program should return the new array as a string, so for this example your program would return 4161023. 
The first element in the array will always be an integer greater than or equal to 0 and less than the size of the array.
*/
using System;

class MainClass {

  public static int ArrayChallenge(int[] arr) 
  {
    int ilk = arr[0];
    string sonuc = "";
    for(int i=ilk;i<arr.Length;i++)
    sonuc+=arr[i];
    for(int i=0;i<ilk;i++)
    sonuc+=arr[i];
    return int.Parse(sonuc);
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}
