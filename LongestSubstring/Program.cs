// See https://aka.ms/new-console-template for more information

///Longest Substring
/// abcabcbb=>3


string characters = "acdcfrg";
//this approach fails as in this case d is lost
int WrongLongestSubstring(string characters)
{
    HashSet<char> charactersSet = new HashSet<char>();
    int count = 0;
    int maxVal = count;
    if (characters == null)
        return 0;
    for (int i = 0; i < characters.Length; i++)
    {

        if (!charactersSet.Contains(characters[i]))
        {
            count++;
            charactersSet.Add(characters[i]);
        }
        else
        {
            count = 1;
            charactersSet = new HashSet<char> { characters[i] };// lost here
        }
        maxVal = Math.Max(maxVal, count);
    }
    return maxVal;

}

///e.g string characters = "acdcfrg";

///sliding window approach
///
int LongestSubstring(string characters)
{
    if (characters == null)
        return 0;
    Dictionary<char, int> charactersSet = new Dictionary<char, int>();
    int longestLength = 0;
    int left = 0;

    for (int right = 0; right < characters.Length; right++)
    {
        char currentCharacter=characters[right];
        if(charactersSet.ContainsKey(currentCharacter) && charactersSet[currentCharacter] >= left)
        {
            charactersSet[currentCharacter]=charactersSet[currentCharacter]+1;
            left=charactersSet[currentCharacter]+1;
        }
        longestLength= Math.Max(longestLength, right-left+1); //since index starts from 0 you need to adjust
    }

    return longestLength;

}


Console.WriteLine(LongestSubstring(characters));
