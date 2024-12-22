// See https://aka.ms/new-console-template for more information

int [] Array=new int[]{5,9,2,9,4};

///Brute Force
///Area
///

int MaxArea(int [] array) {
    if(array.Length<=1)
        return 0;
    int MaxArea=0;
    int area;
    for(int i=0; i<array.Length;i++)
    {
        for(int j=i+1; j<array.Length;j++)
        {
            area=Math.Min(array[i],array[j])*(j-i);
            if(area>MaxArea)
                MaxArea=area;
        }
    }
    return MaxArea;
}

Console.WriteLine("Max area is:" + MaxArea(Array));

///Improve this we use 2 pointers 
///

int MaxAreaTwoPointer(int [] array) 
{
    if(array.Length<=1)
     return 0;
    int leftPointer=0;
    int rightPointer=array.Length-1;
    int maxArea=0;

    while(leftPointer<rightPointer)
    {
        int length=Math.Min(array[leftPointer],array[rightPointer]);
        int width= rightPointer-leftPointer;

        int area=length*width;
        if(area>maxArea)
        {
            maxArea=area;
        }
        if(array[leftPointer]>array[rightPointer])
        {
            rightPointer--;
        }
        else{
            leftPointer++;
        }
    }
    return maxArea;
}

Console.WriteLine("Max area is:" + MaxAreaTwoPointer(Array));