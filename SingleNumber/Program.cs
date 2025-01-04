// See https://aka.ms/new-console-template for more information



using System.Diagnostics;

///Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
///You must implement a solution with a linear runtime complexity and use only constant extra space.
int[] array = { 1, 2, 2, 1, 3, 4, 4 };


///Brute Force
int SingleNumber(int[] nums)
{
    bool isIdentical=false;
    for (int i = 0; i < nums.Length; i++)
    {
        for(int j = 0; j < nums.Length;j++)
        {
            if (nums[i] == nums[j] && i!=j)
            {
                isIdentical = true;
                break;
            }
        }
        if (!isIdentical)
        {
            return nums[i];
        }
        isIdentical=false;
    }
    return -1;
}

///Aproach 2
///

int SingleNumber2(int[] nums)
{
    Array.Sort(nums);
    int left=0;
    for(int right = left+1; right < nums.Length;)
    {
        if(nums[right] == nums[left])
        {
            left=right+1;
            right=left+1;
        }
        else
        {
            return nums[left];
        }
    }
    return nums[left];
}

//Console.WriteLine(SingleNumber2(array));

///Optimal Approach using XOR
///

int SingleNumber3(int[] nums)
{
    int singleNumber =0;
    for (int i = 0;i<nums.Length; i++)
    {
        singleNumber ^= nums[i];
    }
    return singleNumber;
}

Console.WriteLine(SingleNumber3(array));