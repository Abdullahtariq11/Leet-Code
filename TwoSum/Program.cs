// See https://aka.ms/new-console-template for more information

using System.Linq;

///Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///You may assume that each input would have exactly one solution, and you may not use the same element twice.
///You can return the answer in any order.
///
int[] array = { 3, 2, 4, 3, 5 };
int target = 9;


///Brute Force
///

int[] BruteTwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] + nums[i] == target)
            {
                return new int[] {i , j };
            }
        }
    }
    return null;
}

///
/// Optimised Approach
/// Using Hash Table
/// 

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
    for (int i = 0;i<nums.Length;i++)
    {
        result[nums[i]] = i;
    }

    for (int i = 0;i<nums.Length;i++)
    {
        if(result.ContainsKey(target-nums[i]) && result[target-nums[i]]!=i)
        {
            return new[] {i , result.GetValueOrDefault(target-nums[i]) };
        }
    }
    return null;
}

///More optimsed
///
int[] OptimedMoreTwoSum(int[] nums, int target)
{
    Dictionary<int, int> result = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        // Check if complement exists in the dictionary
        if (result.ContainsKey(complement))
        {
            return new[] { result[complement], i };
        }

        // Add the current number and its index to the dictionary
        result[nums[i]] = i;
    }

    return null; // No solution found
}

foreach (int num in TwoSum(array, 9))
{
    Console.WriteLine(num);
}

