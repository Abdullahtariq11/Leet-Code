// See https://aka.ms/new-console-template for more information

///Given four integer arrays nums1, nums2, nums3, and nums4 all of length n, return the number of tuples (i, j, k, l) such that:
///0 <= i, j, k, l < n
///nums1[i] + nums2[j] + nums3[k] + nums4[l] == 0
///

int[] A = { 1, 2 };
int[] B = { -2, -1 };
int[] C = { -1, 2 };
int[] D = { 0, 2 };

int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
{
    Dictionary<int, int> sumMap = new Dictionary<int, int>();
    int sumCount = 0;

    foreach (int num1 in nums1)
    {
        foreach (int num2 in nums2)
        {
            if (!sumMap.ContainsKey(num1 + num2))
            {
                sumMap[num1 + num2] = 0;
            }
            sumMap[num1 + num2]++;
        }
    }
    foreach (int num3 in nums3)
    {
        foreach (int num4 in nums4)
        {
            if (sumMap.ContainsKey(-(num3 + num4)))
            {
                sumCount+=sumMap[-(num3 + num4)];
            }
        }
    }
    return sumCount;
}

