// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

///First and last element of sorted array
///Case #1: [1,3,4,4,4,5] target: 4, return [2,4]
///Case #2: [1,2,3] target: 5, return [-1,-1]
///case #3: [1,2,3] target5: 2, return [1,1]
///


///Brute Force
///

int[] array = { 1, 2, 3, 3, 3, 4 };
int target = 4;

int[] FirstAndLastElement(int[] array, int target)
{

    int firstElement = -1;
    int lastElement = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {

            if (firstElement == -1)
                firstElement = i;

            lastElement = i;
        }
    }

    int[] result = { firstElement, lastElement };

    return result;

}

///Optimised approach since array is sorted and we want to find something think binary search
///

int[] FirstandLastElementOptimised(int[] array, int target)
{
    int firstElement;
    int lastElement;

    firstElement=SearchIndex(array, target,true);

    if (firstElement == -1)
        return new int[] { -1, -1 };

    lastElement = SearchIndex(array, target, false);

    return new int[] {firstElement,lastElement };

}

int SearchIndex(int[] array, int target,bool isFirst)
{
    int left = 0;
    int right = array.Length - 1;
    int bound = -1;


    while (left <= right)
    {
        int mid=left+(right-left)/2;

        if (array[mid] == target)
        {
            bound = mid;
            if (isFirst)
            {
              
                right = mid - 1;
            }
            else
            {
                {
                    left = mid + 1;
                }
            }
        }

        else if (array[mid] <= target)
        {
            left = mid + 1;
        }

        else
        {
            right = mid - 1;
        }
    }

    return bound;

}


int[] result = FirstandLastElementOptimised(array, target);
Console.WriteLine($"{result[0]},{result[1]}");
