using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Word
    {
        public Word(string wordText)
        {
            _text = wordText;
        }
        private string _text="";             

        public string GetWord()
        {
            return _text;
        }

        public void HideWord()
        {
            string newText="";
            foreach (char x in _text) newText += "_";
            _text=newText;
        }
    }
}