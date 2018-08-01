public static int MaxSubarray3(Subarray input)
{
  if(input.Left == input.Right){
    return input.Array[input.Left];
  }
  
  int mid = (input.Left + input.Right)/2;
  
  Subarray leftSubarray = new Subarray(input.Array, input.Left, mid);
  Subarray rightSubarray = new Subarray(input.Array, mid + 1, input.Right);
  
  int leftSum = MaxSubarray3(leftSubarray);
  int rightSum = MaxSubarray3(rightSubarray);
  int crossSum = MaxCrossingSubarray(input, mid);
  
  if (leftSum >= rightSum && leftSum >= crossSum)
  {
    input.Left = leftSubarray.Left;
    input.Right = rightSubarray.Right;
    
    return leftSum;
  }
  else if(rightSum >= leftSum && rightSum >= crossSum)
  {
    input.Left = rightSubarray.Left;
    input.Right = rightSubarray.Right;
    
    return rightSum;
  }
  else
  {
    return crossSum;
  }
}

public static int MaxCrossingSubarray(Subarray input, int mid)
{
  int s = input.Array[mid];
  int left = mid;
  int leftSum = input.Array[mid];
  for (int i = mid - 1; i >= input.Left; i--)
  {
    s += input.Array[i];
    if(leftSum < s)
    {
      left = i;
      leftSum = s;
    }
  }
  s = input.Array[mid + 1];
  int right = mid + 1;
  int rightSum = input.Array[mid + 1];
  for(int i = mid + 1; i <= input.Right; i++)
  {
    s += input.Array[i];
    if(rightSum < s)
    {
      right = i;
      rightSum = s;
    }
  }
  input.Left = left;
  input.Right = right;
  
  return leftSum + rightSum;
}
