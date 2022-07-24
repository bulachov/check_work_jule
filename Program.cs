string[] GetData(string path)
{
    string s = File.ReadAllText(path);
    string[] data = s.Split(' ');
    return data;
}

string[] MainTask(string[] tosort, int howManySimbol)
{
    string[] result = new string[0];
    for (int i = 0; i < tosort.Length; i++)
    {
        if (tosort[i].Length <= howManySimbol)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = tosort[i];
        }

    }
}



