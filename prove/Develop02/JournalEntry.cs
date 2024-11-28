using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop04
{
    public class JournalEntry
    {

    public string _prompt="";
    public string _answer="";
    public DateTime _date=Convert.ToDateTime("1/1/1900");

    public void CreateEntry()
    {
        _prompt=Prompt.GetRandomPrompt();
        Console.Write(_prompt + " ");
        _answer = Console.ReadLine();
        _date = DateTime.Now;
    }

    

    public void ImportEntry(string textLine)
    {
        //Date|Prompt|Answer
        string[] strEntry=textLine.Split("|");
        _prompt=strEntry[1];
        _date=Convert.ToDateTime(strEntry[0]);
        _answer=strEntry[2];
    }

    public string ExportEntry(string textLine)
    {
        return _date + "|" + _prompt + "|" + _answer;
    }


    
        
    }
}