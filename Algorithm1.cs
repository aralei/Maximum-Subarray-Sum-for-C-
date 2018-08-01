using System;

public class Subarray {
  public Subarray(int[] array, int left, int right) {
    Ary = array;
    Left = left;
    Right = right;
  }
  
  public int[] Ary {get; set;}
  public int Left {get; set;}
  public int Right {get; set;}
}

public static int MaxSubarray1(Subarray input) {
  int left = input.Left;
  int right = input.Right;
  int maxSum = input.Array[input.Left];
  
  for (int i = input.Left; i <= input.Right; i++)
    for (int j = i; j <= input.Right; j++)
    {
      int sum = 0;
      for (int k = 0; k <= j; k++)
      {
        sum += input.Array[k];
        if(maxSum < sum)
        {left = i;
         right = j;
         maxSum = sum;
        }
      }
    }
    input.Left = left;
    input.Right = right;
    return maxSum;
  
}
