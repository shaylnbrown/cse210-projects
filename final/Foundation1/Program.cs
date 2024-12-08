using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        List<Video> VideoList=new List<Video>();
        VideoList.Add(new Video("Monkey eats popcorn","Matt",42));
        VideoList[0].CreateDemoComments(0);
        VideoList.Add(new Video("Toddler says a curse word","Seth",22));
        VideoList[1].CreateDemoComments(1);
        VideoList.Add(new Video("The Gatoraid challenge","Eddie",68));
        VideoList[2].CreateDemoComments(2);
        VideoList.Add(new Video("The election skit","Jack",161));
        VideoList[3].CreateDemoComments(3);    

        int count=1;
        foreach (Video video in VideoList)
        {
            Console.WriteLine();
            Console.WriteLine($"Video #{count}");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetCommentCount()}):");
            Console.WriteLine(video.DisplayCommentList());
            count++;
        }               
    }
}