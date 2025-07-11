// See https://aka.ms/new-console-template for more information

//1071. Greatest Common Divisor of Strings
//For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t 
// (i.e., t is concatenated with itself one or more times).
// Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.

using System.ComponentModel.DataAnnotations;
using System.Text;


string GcdOfStrings(string str1, string str2)
{

    //string sum should be same if we add them in reverse order to be divisible
    if(str1+str2 != str2+str1)
    {
        return "";
    }
    int a= str1.Length;
    int b= str2.Length;
    //Euclidean Algorithm
    while(b!=0)
    {
        int temp=b;
        b=a%b;
        a=temp;
    }
    return str2.Substring(0, a);

}

Console.WriteLine(GcdOfStrings("ABABABAB", "ABAB"));
