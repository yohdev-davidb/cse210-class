using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {


    }

    public void LoadFromFile(string file)
    {

    }
}