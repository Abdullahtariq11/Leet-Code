// See https://aka.ms/new-console-template for more information

///Given two binary strings a and b, return their sum as a binary string.
///

string a = "11";
string b = "1";

string AddBinary(string a, string b)
{
    int i = a.Length - 1;
    int j = b.Length - 1;
    int carry = 0;
    string result = "";
    int sum = 0;

    while (i >= 0 || j >= 0 || carry > 0)
    {
        sum = carry;

        if (i >= 0)
        {
            sum += a[i] - '0'; //subtract from 0 as its asci code is 48 which gives 1 otherwise we get 49
            i--;
        }
        if (j >= 0)
        {
            sum += a[j] - '0'; //subtract from 0 as its asci code is 48 which gives 1 otherwise we get 49
            j--;
        }
        result = (sum % 2) + result;
        carry = sum / 2;
    }
    return result;
}
