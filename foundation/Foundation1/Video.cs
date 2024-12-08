using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Video
    {
        string _title="";
        string _author="";
        int _length=0;
        List<Comment> CommentList = new List<Comment>();        

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        } 

        public void CreateDemoComments(int commentSet)
        {
            if (commentSet==0)
            {                
                CommentList.Add(new Comment("Phil","This video changed my life!"));
                CommentList.Add(new Comment("Ned","What a waste of time!"));
                CommentList.Add(new Comment("Tiberius","I don't get the significance of the shoe!"));
                CommentList.Add(new Comment("Avery","This is hilarious!"));                
            }
            if (commentSet==1)
            {
                CommentList.Add(new Comment("Tyson","This video is so confusing!"));
                CommentList.Add(new Comment("Stanley","They should make this into a high budget movie!"));
                CommentList.Add(new Comment("Lucy","I watched this while I went potty!"));
                CommentList.Add(new Comment("Brad","I want the time I spent watching this video back!"));                
            }
            if (commentSet==2)
            {
                CommentList.Add(new Comment("Jayce","This made me cry!"));
                CommentList.Add(new Comment("Alex","My wife made me watch this!"));
                CommentList.Add(new Comment("Kevin","This made me fall asleep!"));
                CommentList.Add(new Comment("Brett","The music is way too loud!"));                
            }
            if (commentSet==3)
            {
                CommentList.Add(new Comment("Josh","This was based on my life!"));
                CommentList.Add(new Comment("Russell","I can't understand half the things being said!"));
                CommentList.Add(new Comment("Chad","I watched this three times!"));
                CommentList.Add(new Comment("Jeremy","The camera work gives me a headache!"));                
            }           
        }       

        public string DisplayCommentList()
        {
            if (CommentList.Count == 0) return "This video has no comments";
            string output="";
            foreach (Comment comment in CommentList)
            {
                if (output != "") output+="\n";
                output += comment.GetComment();
            }
            return output;
        }

        public int GetCommentCount()
        {            
            return CommentList.Count;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public int GetLength()
        {
            return _length;
        }


    }

    

    
}