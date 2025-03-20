// See https://aka.ms/new-console-template for more information

using System.Text;


///
///You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
/// If a string is longer than the other, append the additional letters onto the end of the merged string.
/// Return the merged string.
///
string word1 = "abc";
string word2 = "pqrs";

string MergeAlternately(string word1, string word2)
{
    int length1=word1.Length;
    int length2=word2.Length;
    char [] mergedArray=new char[length1+length2+1];

    int leftIndex=0, rightIndex=0;
    int index=0;

    while (leftIndex < length1 && rightIndex< length2)
    {
        mergedArray[index]=word1[leftIndex];
        leftIndex++;
        index++;
        mergedArray[index]=word2[rightIndex];
        rightIndex++;
        index++;
    }
    while(rightIndex < length2)
    {
        mergedArray[index] = word2[rightIndex];
        index++;
        rightIndex++;
    }
        while(leftIndex < length1)
        
    {
        mergedArray[index] = word1[leftIndex];
        index++;
        leftIndex++;
    }
    
    
    return new string(mergedArray);
}

Console.WriteLine(MergeAlternately(word1,word2));

// alternative approach using string builder class
string MergeAlternately2(string word1, string word2)
{
    StringBuilder mergedString= new StringBuilder();
    int i=0,j=0;

    while(i<word1.Length || j<word2.Length)
    {
        if(i<word1.Length) mergedString.Append(word1[i]);
        if(j<word2.Length) mergedString.Append(word2[j]);
    }

    return mergedString.ToString();
}

