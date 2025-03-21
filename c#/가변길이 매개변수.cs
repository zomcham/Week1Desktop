using UnityEngine;

public void Sum (params int[] nums)
{
    int sum=0;
    for(int i=0; i<nums.Length; ++i)
    {
          Sum+=nums[i];
    }
Debig.Log($"합계:(sum)");
}