// See https://aka.ms/new-console-template for more information



using System.Linq;

///Given an integer array nums, return true if any value appears at least twice in the array,
///and return false if every element is distinct.
///
///HashMap
///
bool ContainsDuplicate(int[] nums)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
    for(int i = 0; i < nums.Length;i++)
    {
        if(result.ContainsKey(nums[i]))
        {
            return true;
        }
        result[nums[i]] = i;
    }
    return false;
}

int [] nums={1,2,3,1};
Console.WriteLine(ContainsDuplicate(nums));