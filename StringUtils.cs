Dictionary<char, int> NumberOfCharactersOccurences(string inputString)
{
    var output = new Dictionary<char, int>();
    while (inputString.Length>0)
    {
        int count = 0;
        for (int j = 0; j<inputString.Length; j++)
        {
            if (inputString[0] == inputString[j])
                count++;
        }
        output.Add(inputString[0], count);
        inputString = inputString.Replace(inputString[0].ToString(), string.Empty);
    }
    return output;
}