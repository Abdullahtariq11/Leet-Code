// See https://aka.ms/new-console-template for more information


//array with each person weight
int[] personWeight = {3,2,1,2,5};



int NumberOfBoats(int[] array,int weightLimit) //O(nlogn) 
{
    //use two pointer approach. Sort array to use this approach
    Array.Sort(array);
    int lightest = 0;
    int biggest= array.Length-1;

    int boats = 0;

    while (lightest <= biggest)
    {
        if (lightest + biggest <= weightLimit)
        {
            lightest++;
        }

        boats++;
        biggest--;
    }
    return boats;
}

Console.WriteLine("Number of boats:"+NumberOfBoats(personWeight,5));


