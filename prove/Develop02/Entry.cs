using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryTime;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} Time: {_entryTime}");
        Console.WriteLine($"Prompt Question: {_promptText}");
        Console.WriteLine($"Journal Entry: {_entryText} \n");
    }

}
