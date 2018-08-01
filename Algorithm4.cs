public static int MaxSubarray4(Subarray input)
{
  int leftEndingHere = input.Left;
  int maxEndingHere = input.Array[input.Left];
  
  int left = input.Left;
  int right = input.Right;
  int max = input.Array[input.Left];
  
  for(int i = input.Left + 1; i <= input.Right; i++)
  {
    int sum = maxEndingHere + input.Array[i];
    
    if(sum < input.Array[i])
    {
      leftEndingHere = i;
      maxEndingHere = input.Array[i];
    }
    else
    {
      maxEndingHere = sum;
    }
    
    if(max < maxEndingHere)
    {
      left = leftEndingHere;
      right = i;
      max = maxEndingHere;
    }
  }
  input.Left = left;
  input.Right = right;
  
  return max;
}
