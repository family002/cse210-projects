using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    public DateTime DateTime { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(DateTime dateTime, string prompt, string response)
    {
        DateTime = dateTime;
        Prompt = prompt;
        Response = response;
    }

    public string GetDate()
    {
        return DateTime.ToShortDateString();
    }

    public string GetTime()
    {
        return DateTime.ToShortTimeString();
    }
    public override string ToString()
    {
        return $"{DateTime.ToShortDateString()} {DateTime.ToShortTimeString()} - {Prompt}\n{Response}\n";
    }
}