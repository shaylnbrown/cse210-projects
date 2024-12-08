using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");                
        Lecture lecture = new Lecture("Lecture","Nacho Quest","Man's Search for Good Nachos","Jan 5, 2024","7:00 PM","4156 Grand Ave", "Springfield", "MO",45172,"Shay Brown",85);
        Console.WriteLine("\n--------Lecture Short--------");
        Console.WriteLine(lecture.GetShortDescription() + "\n");
        Console.WriteLine("--------Lecture Standard--------");
        Console.WriteLine(lecture.GetStandardDetails() + "\n");
        Console.WriteLine("--------Lecture Full--------");
        Console.WriteLine(lecture.GetFullDetails() + "\n");
        OutdoorGathering outdoor = new OutdoorGathering("Outdoor Gathering","Taco Tuesday","Eating tacos outside","June 18, 2024","7:00 PM","4156 Grand Ave", "Springfield", "MO",45172,"Cloudy With a Chance of Meatballs");
        Console.WriteLine("\n--------Outdoor Short--------");
        Console.WriteLine(outdoor.GetShortDescription() + "\n");
        Console.WriteLine("--------Outdoor Standard--------");
        Console.WriteLine(outdoor.GetStandardDetails() + "\n");
        Console.WriteLine("--------Outdoor Full--------");
        Console.WriteLine(outdoor.GetFullDetails() + "\n");
        Reception reception = new Reception("Reception","Mission Accomplished","Celebrating the perfect plate of nacos","Sep 4, 2024","7:00 PM","4156 Grand Ave", "Springfield", "MO",45172,"awesomenachos@gmail.com");
        Console.WriteLine("\n--------Reception Short--------");
        Console.WriteLine(reception.GetShortDescription() + "\n");
        Console.WriteLine("--------Reception Standard--------");
        Console.WriteLine(reception.GetStandardDetails() + "\n");
        Console.WriteLine("--------Reception Full--------");
        Console.WriteLine(reception.GetFullDetails() + "\n");
    }
}