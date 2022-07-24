string[] GetData(string path)
{
    string s = File.ReadAllText(path);
    string[] data = s.Split(' ');
    return data;
}

string[] MainTask(string[] tosort, int Simbol)
{
    string[] result = new string[0];
    for (int i = 0; i < tosort.Length; i++)
    {
        if (tosort[i].Length <= Simbol)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = tosort[i];
        }

    }
    return result;
}

string Print(string[] array)
{
    string back = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        back += ($"array[{i + 1}]: {array[i]} ");
    }
    return back;
}

int howManySimbol = 3;

string[] a = GetData("datatosort.txt");
File.WriteAllText("indata.txt", Print(a));

string[] b = MainTask(a, howManySimbol);
File.WriteAllText("outdata.txt", Print(b));
