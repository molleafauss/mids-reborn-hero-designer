using System;

/**
 * Classes present in HeroDesigner.Schema - moved to a C# dialect as VS2019 had trouble loading the project
 */
public class RawSaveResult
{
    internal int Length;
    internal int Hash;

    public RawSaveResult(int length, int hash)
    {
        this.Length = length;
        this.Hash = hash;
    }
}

public class FHash
{
    internal string Archetype;
    internal string Fullname;
    internal int Hash;
    internal int Length;

    public FHash(string archetype, string fullname, int hash, int length)
    {
        Archetype = archetype;
        Fullname = fullname;
        Hash = hash;
        Length = length;
    }
}

public class HistoryMap
{
    internal int Level = -1;
    internal int HID = -1;
    internal int SID = -1;
    internal string Text = String.Empty;
}