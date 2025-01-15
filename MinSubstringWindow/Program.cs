// See https://aka.ms/new-console-template for more information
///Given two strings s and t of lengths m and n respectively, return the minimum window substring
/// of s such that every character in t (including duplicates) is included in the window.
/// If there is no such substring, return the empty string "".
/// 

string s = "ADOBECODEBANC";
string t = "ABC";

string MinWindow(string s, string t)
{
    if (t.Length > s.Length || t.Length == 0 || s.Length == 0)
        return "";

    int left = 0;
    int right = 0;
    int formed = 0;
    int[] result = { -1, 0, 0 }; // {minLength, leftIndex, rightIndex}

    Dictionary<char, int> requiredFrequency = new Dictionary<char, int>(); ///frequency of each character in t
    Dictionary<char, int> trackWindow = new Dictionary<char, int>(); // minimum window of character with their indices

    foreach (char c in t)
    {
        if (!requiredFrequency.ContainsKey(c))
        {
            requiredFrequency[c] = 0;
        }
        requiredFrequency[c]++;
    }

    while (right < s.Length)
    {
        char c = s[right];
        if (!trackWindow.ContainsKey(c))
        {
            trackWindow[c] = 0;
        }
        trackWindow[c]++;

        if (requiredFrequency.ContainsKey(c) && requiredFrequency[c] == trackWindow[c])
        {
            formed++;
        }

        while (left <= right && formed == requiredFrequency.Count)
        {
            c = s[left];
            int smalllestWindow = right - left + 1;
            if (result[0] == -1 || smalllestWindow < result[0])
            {
                result[0] = smalllestWindow;
                result[1] = left;
                result[2] = right;
            }
            trackWindow[c]--;
            if (requiredFrequency.ContainsKey(c) && trackWindow[c] < requiredFrequency[c])
            {
                formed--;
            }
            left++;
        }
        right++;
    }
    return result[0]== -1 ?"": s.Substring(result[1],result[0]);

}