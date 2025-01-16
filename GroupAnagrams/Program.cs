// See https://aka.ms/new-console-template for more information

///Given an array of strings strs, group the anagrams together. You can return the answer in any order.
///

string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

IList<IList<string>> GroupAnagrams(string[] strs)
{

    if (strs.Length == 0) return new List<IList<string>>();
    
    IList<IList<string>> result = new List<IList<string>>();
    Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();
    foreach (var str in strs)
    {
        string key = new string(str.OrderBy(x => x).ToArray());

        if (group.ContainsKey(key))
        {
            group[key].Add(str);
        }
        else
        {
            group[key] = new List<string> { str }; // Initialize and add the string
        }
    }

    foreach (var str in group)
    {
        result.Add(str.Value.ToList());
    }
    return result;

}
