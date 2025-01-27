using System;

public class Entry
{

    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string Date, string PromptText, string EntryText)
    {

        _date = Date;
        _promptText = PromptText;
        _entryText = EntryText;
    }


    public void Display()
    {
        Console.WriteLine("$Date:{_date}");
        Console.WriteLine("$Prompt:{_promptText}");
        Console.WriteLine("$Respone:{_entryText}");
        Console.WriteLine("---------------------------");
    }



}

