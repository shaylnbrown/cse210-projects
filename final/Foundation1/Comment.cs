using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Comment
    {
        public Comment(string name, string comment)
        {
            _name = name;
            _commentText = comment;
        }
        string _name="";
        string _commentText="";

        public string GetComment()
        {
            return $"{_name}: {_commentText}";
        }
    }
}