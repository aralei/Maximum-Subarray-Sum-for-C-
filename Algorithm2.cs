using System;

public static int MaxSubarray2(Subarray input)
{
  int left = input.Left;
  int right = input.Right;
  int maxSum = input.Array[input.Left];
  
  for (int i = input.Left; i <= input.Right; i++)
  {
    int sum = 0;
    for (int j = i; j<=input.Right; j++)
    {
      sum += input.Array[j];
      if(sum > maxSum)
      {
        left = i;
        right = j;
        maxSum = sum;
      }
    }
  }
  input.Left = left;
  input.Right = right;
  
  return maxSum;
}
