// See https://aka.ms/new-console-template for more information


///First Bad Version
///

bool IsBadVersion(int n)
{
    return n>=5;
}

int [] versions={1,2,3,4,5,6}; //since these are verions have to be sorted.

///Brute Force
///

int? FirstBadversion(int[] array){
    for (int i=0; i<array.Length;i++)
    {
        if(IsBadVersion(array[i]))
        {
            return array[i];
        }
    }
    return null;
}

int FirstBadVersionEfficient(int[] array)
{
    int left=0;
    int right=array.Length-1;
    int mid;
    int firstVersion=-1;

    while (left<=right)
    {
        mid=left+(right-left)/2;
        if(IsBadVersion(array[mid]))
        {
            firstVersion=array[mid];
            right=mid-1;
        }
        else
        {
            left=mid+1;
        }
    }
    return firstVersion;
}

Console.WriteLine(FirstBadVersionEfficient(versions));