// See https://aka.ms/new-console-template for more information

///
/// Move Zeros
/// 
/// If array [0,1,0,3,12] to [1,3,12,0,0]
///

///Brute force would mean creating a new array and returning it with extra memory

int [] array1= {0,1,0,3,12};

void MoveZeros(int[] array)
{
    int j=0;
    for (int i = 0;i<array.Length ;i++ )  
    {
        if(array[i] != 0)
        {
            array[j]=array[i];
            j++;
        }
    }
    while (j < array.Length)
    {
        array[j]=0;
        j++;
    }
    
}

void PrintArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

MoveZeros(array1);
PrintArray(array1);
