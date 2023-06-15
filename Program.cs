internal class Program
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

    class BankAccount
    {
        public int AccountNumber = 11211212;
        public string OwnerName = "Mohammed Abdullah";
        public double Balance;
    }

    class Employee
    {
        public string Name = "Ahmed";
        public string Position = ".Net Developer";
        public double Salary = 2000;
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
        BankAccount bankAccount = new BankAccount();
        Console.WriteLine("AccountNumber: " +bankAccount.AccountNumber);
        Console.WriteLine("OwnerName: " + bankAccount.OwnerName);
        Console.WriteLine((bankAccount.Balance = 50.554)+" RO");

        Console.WriteLine(" -----------------------------------");
        Employee employee = new Employee();
        Console.WriteLine("The Name is: " + employee.Name);
        Console.WriteLine("Posiiton: " + employee.Position);
        Console.WriteLine("Salary: " + employee.Salary);


    }
} 