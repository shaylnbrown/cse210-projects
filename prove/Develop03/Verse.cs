using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Verse
    {
        private List<Word> _words=new List<Word>();

        public Verse(string verseText)
        {
            string[] chunks=verseText.Split(' ');            
            foreach (string chunk in chunks)
            {
                Word newWord=new Word(chunk);
                _words.Add(newWord);
            }            
        }

        public List<Word> getWordList()
        {
            return _words;
        }

        public string getVerseText()
        {
            string verseText=_words[0].GetWord();
            foreach (Word word in _words.Skip(1)) verseText += " " + word.GetWord();
            return verseText;
        }

        public void blankWord(string wordIn)
        {
            foreach(Word word in _words)
            {
                if (word.GetWord() == wordIn) word.HideWord();
            }
        }


    }
}