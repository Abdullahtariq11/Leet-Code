// See https://aka.ms/new-console-template for more information

///Given an array nums containing n distinct numbers in the range [0, n],
///return the only number in the range that is missing from the array.
///

///Constraints:
///n == nums.length
///1 <= n <= 104
///0 <= nums[i] <= n
///All the numbers of nums are unique.

int[] array = { 1, 0, 3 };


///Time Complexity O(nlogn)
int MissingNumber(int[] nums)
{

    int n = nums.Length;
    Array.Sort(nums);

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != i)
            return i;
    }

    return n;
}
///Second approach
///Time Complexity O(n)
int MissingNumberApproach(int[] nums)
{

    Dictionary<int, bool> isPresent = new Dictionary<int, bool>();
    int n = nums.Length;

    for (int i = 0; i < n; i++)
    {
        if (!isPresent.ContainsKey(nums[i]))
        {
            isPresent[nums[i]] = true;
        }
    }

    for (int i = 0; i <= n; i++)
    {
        if (!isPresent.ContainsKey(i))
            return i;
    }
    return -1;
}

Console.WriteLine(MissingNumber(array));

///Using Math
///s=n(n+1)/2
///Time Complexity O(n)
///Space Complexity O(1)

int MissingNumberMath(int[] nums)
{
    int n = nums.Length;
    int sum = n * (n + 1) / 2;
    for (int i = 0; i < nums.Length; i++)
    {
        sum = sum - nums[i];
    }
    return sum;

}