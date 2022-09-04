/*
Link : https://www.codewars.com/kata/578553c3a1b8d5c40300037c/train/csharp

Given an array of ones and zeroes, convert the equivalent binary value to an integer.

Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.

Examples:

Testing: [0, 0, 0, 1] ==> 1
Testing: [0, 0, 1, 0] ==> 2
Testing: [0, 1, 0, 1] ==> 5
Testing: [1, 0, 0, 1] ==> 9
Testing: [0, 0, 1, 0] ==> 2
Testing: [0, 1, 1, 0] ==> 6
Testing: [1, 1, 1, 1] ==> 15
Testing: [1, 0, 1, 1] ==> 11
However, the arrays can have varying lengths, not just limited to 4.
*/

int[] Test1 = new int[] {0,0,0,0};
    int[] Test2 = new int[] {1,1,1,1};
    int[] Test3 = new int[] {0,1,1,0};
    int[] Test4 = new int[] {0,1,0,1};

Console.WriteLine(binaryArrayToNumber(Test1));  // expected 0
Console.WriteLine(binaryArrayToNumber(Test2));  // expected 15
Console.WriteLine(binaryArrayToNumber(Test3));  // expected 6
Console.WriteLine(binaryArrayToNumber(Test4));  // expected 5

static int binaryArrayToNumber(int[] BinaryArray)
        {
          int total = 0;
          int arrLen = BinaryArray.Length;
          int highest = 1;
        
          for(int i = 1; i <= arrLen; i++) {
            highest = highest*2;
          }
         
        
          for(int i = 0; i < arrLen; i++) {
            highest /= 2;
            if( BinaryArray[i] == 1) {
              
              total += highest;
              
            }
          }
        return total;
        }
