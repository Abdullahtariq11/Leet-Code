// See https://aka.ms/new-console-template for more information

///Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
/// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
/// Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
/// Return k.
/// 

int RemoveElement(int[] nums, int val)
{
    int places = 0;
    int i = 0;
   
    while (i < nums.Length)
    {
        if (nums[i] == val)
        {
            i++;
            places++;

        }
        else
        {
            nums[i - places] = nums[i];
            i++;

        }
    }
    return nums.Length-places ;
}

int[] nums = new int[] { 3, 2, 2, 3 };

Console.WriteLine(RemoveElement(nums, 3));
