internal class Program
{
    class Car
    {
        public string color = "red";
        public int speed = 120;
        public int model = 2023;
    }
    private static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine("my car colour is: "+myObj.color);
        Console.WriteLine("I am driving: "+myObj.speed);
        Console.WriteLine("My car model is: "+myObj.model);
    }
} 