using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Scripture
    {
        string[] _lines=new string[0];
        Reference _reference;
        List<Verse> _verses=new List<Verse>();

        public Scripture()
        {
            _lines=System.IO.File.ReadAllLines("scripture.txt"); 
            _reference=new Reference(_lines); 
            foreach (string line in _lines.Skip(1))    
            {
                Verse newVerse=new Verse(line);
                _verses.Add(newVerse);
            }
        }

        public string GetScriptureText()
        {
            string scriptureText=_reference.GetReferenceText();
            foreach (Verse verse in _verses)
            {
                scriptureText += "\n" + verse.getVerseText();
            }            
            return scriptureText;

        }

        public List<string> getWordList()
        {
            List<string> listOut=new List<string>();
            List<Word> wordList=new List<Word>();
            string testWord="";
            foreach (Verse verse in _verses)
            {
                wordList=verse.getWordList();
                foreach (Word word in wordList)
                {
                    testWord = word.GetWord();
                    if (!listOut.Contains(testWord)) listOut.Add(testWord);
                }                
            }
            return listOut;
        }

        public void BlankWord(string wordIn)
        {
            foreach (Verse verse in _verses) verse.blankWord(wordIn);

        }        
    }
}