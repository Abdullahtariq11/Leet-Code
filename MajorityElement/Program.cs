// See https://aka.ms/new-console-template for more information

///Given an array nums of size n, return the majority element.
///The majority element is the element that appears more than ⌊n / 2⌋ times. 
///You may assume that the majority element always exists in the array.
///

int[] nums = { 3, 2, 3 };
///O(n) O(n)
int MajorityElement(int[] nums)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (result.ContainsKey(nums[i]))
        {
            result[nums[i]]++;
        }
        else
        {
            result[nums[i]] = 1;
        }
        if (result[nums[i]] > nums.Length / 2)
        {
            return nums[i];
        }
    }
    return -1;
}
///Boyer Moore voting algorithm
int OptimalMajorityElement(int[] nums)
{
    int candidate = nums[0];
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (count == 0)
        {
            candidate = nums[i];
        }
        count += candidate == nums[i] ? 1 : -1;
    }
    return candidate;
}


Console.WriteLine(MajorityElement(nums));