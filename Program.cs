﻿internal class Program
{
    class Book
    {
        public string title = "The history of Oman";
        public string author = "Al - Sakiti";
        public int year = 1999;
    }

    class Circle
    {
        
        public double diameter;
        public double radius;
        

    }

    private static void Main(string[] args)
    {
        Book myObj = new Book();
        Console.WriteLine("The title is: "+myObj.title);
        Console.WriteLine("By: "+myObj.author);
        Console.WriteLine("Published in: "+myObj.year);
        Console.WriteLine(" -----------------------------------");

        Circle circle = new Circle();
        circle.diameter = 50;
        circle.radius = circle.diameter / 2;
        Console.WriteLine("The radius is " + circle.radius 
            + " when the diameter is " + circle.diameter);
        Console.WriteLine(" -----------------------------------");

        

    }
} 