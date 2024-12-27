// See https://aka.ms/new-console-template for more information

int[] mountainArray = { 0, 3, 2, 1 };

bool IsMountainarray(int[] array)
{
    if (array.Length < 3 )
     return false; 

    int i = 0;


    while (i<array.Length-1 && array[i + 1] > array[i])
    {
        i++;

    }

    //cannot be peak at first or end
    if(i==0 || i==array.Length-1)
        return false;
    while (i <= (array.Length-1 ) && array[i] < array[i+1] )
    {
        i++;

    }
    return i == (array.Length-1) ? true : false;
}

Console.WriteLine(IsMountainarray(mountainArray));
