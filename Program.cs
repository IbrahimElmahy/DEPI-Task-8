#region Task 1: Interface Implementation (IVehicle)

//using System;

//interface IVehicle
//{
//    void StartEngine();
//    void StopEngine();
//}

//class Car : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Car engine started.");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Car engine stopped.");
//    }
//}

//class Bike : IVehicle
//{
//    public void StartEngine()
//    {
//        Console.WriteLine("Bike engine started.");
//    }

//    public void StopEngine()
//    {
//        Console.WriteLine("Bike engine stopped.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        IVehicle myCar = new Car();
//        IVehicle myBike = new Bike();

//        myCar.StartEngine();
//        myCar.StopEngine();

//        myBike.StartEngine();
//        myBike.StopEngine();
//    }
//}



//Why is it better to code against an interface rather than a concrete class?

//Flexibility:
//By coding against an interface, you can replace or extend implementations without affecting the code that uses the interface. For instance, if a new class Truck implements IVehicle, it can seamlessly integrate into the program.

//Dependency Inversion Principle:
//Interfaces promote dependency on abstractions rather than concrete implementations, adhering to one of the core principles of object-oriented programming (OOP).

//Testability:
//Interfaces make it easier to create mock objects for testing since you can substitute concrete classes with test implementations.

//Code Reusability:
//Interfaces encourage the creation of reusable code components.
#endregion

#region  Task 2: Abstract Class Implementation (Animal)
//using System;

//abstract class Shape
//{
//    public abstract double GetArea();

//    public void Display()
//    {
//        Console.WriteLine($"The area of this shape is: {GetArea()}");
//    }
//}

//class Rectangle : Shape
//{
//    private double _width;
//    private double _height;

//    public Rectangle(double width, double height)
//    {
//        _width = width;
//        _height = height;
//    }

//    public override double GetArea()
//    {
//        return _width * _height;
//    }
//}

//class Circle : Shape
//{
//    private double _radius;

//    public Circle(double radius)
//    {
//        _radius = radius;
//    }

//    public override double GetArea()
//    {
//        return Math.PI * _radius * _radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape rectangle = new Rectangle(5, 10);
//        Shape circle = new Circle(7);

//        rectangle.Display();
//        circle.Display();
//    }
//}


//What is the difference between an interface and an abstract class?

//An interface is a contract that defines the methods and properties that a class must implement.
//It cannot contain any implementation details. In contrast, an abstract class can contain both abstract and concrete methods,
//providing default implementations for some methods.

#endregion

#region Task 3: Implementing IComparable for Product Sorting

//using System;

//class Product : IComparable<Product>
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Price { get; set; }

//    public Product(int id, string name, double price)
//    {
//        Id = id;
//        Name = name;
//        Price = price;
//    }

//    // Implementing IComparable to compare by Price
//    public int CompareTo(Product other)
//    {
//        if (other == null) return 1;
//        return Price.CompareTo(other.Price);
//    }

//    public override string ToString()
//    {
//        return $"Product ID: {Id}, Name: {Name}, Price: {Price}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product[] products = {
//            new Product(1, "Laptop", 1500),
//            new Product(2, "Phone", 800),
//            new Product(3, "Tablet", 1200)
//        };

//        // Sorting the array using IComparable implementation
//        Array.Sort(products);

//        Console.WriteLine("Products sorted by Price:");
//        foreach (var product in products)
//        {
//            Console.WriteLine(product);
//        }
//    }
//}

//How does implementing IComparable improve flexibility in sorting?

//Custom Sorting Logic:
//By implementing IComparable, you define a standard way to compare objects.
//In this case, sorting is based on the Price attribute, but you could customize the logic for other attributes (e.g., Name or Id).
//Seamless Integration with Sorting Methods:
//Standard sorting methods like Array.Sort() and List<T>.Sort() use the CompareTo method to order objects, enabling effortless sorting of custom types.
//The comparison logic defined in IComparable is reusable across the application, avoiding duplication of sorting code.
//If additional sorting needs arise, IComparer can complement IComparable to provide alternative comparison strategies.

#endregion

#region Task 4: Deep vs. Shallow Copy(Student)
//using System;

//class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Grade { get; set; }

//    public Student(int id, string name, string grade)
//    {
//        Id = id;
//        Name = name;
//        Grade = grade;
//    }

//    public Student(Student other)
//    {
//        Id = other.Id;
//        Name = other.Name;
//        Grade = other.Grade;
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student original = new Student(1, "Alice", "A");

//        Student shallowCopy = original;

//        Student deepCopy = new Student(original);

//        Console.WriteLine("Before modification:");
//        Console.WriteLine($"Original: {original}");
//        Console.WriteLine($"Shallow Copy: {shallowCopy}");
//        Console.WriteLine($"Deep Copy: {deepCopy}");

//        original.Name = "Bob";
//        original.Grade = "B";

//        Console.WriteLine("\nAfter modification:");
//        Console.WriteLine($"Original: {original}");
//        Console.WriteLine($"Shallow Copy: {shallowCopy}");
//        Console.WriteLine($"Deep Copy: {deepCopy}");
//    }
//}

//What is the primary purpose of a copy constructor in C#?

//Creating Independent Copies:
//A copy constructor is used to create a new object that is an exact copy of an existing one, ensuring no shared references between the two.
//Deep Copy:
//Unlike shallow copies, which only copy references, deep copies duplicate the entire object structure, making the new object independent of the original.
//Preserving Encapsulation:
//A copy constructor provides a controlled way to duplicate objects, adhering to encapsulation by ensuring proper copying of fields, especially when they involve complex data types or references.

#endregion

#region Task 5: Explicit Interface Implementation (IWalkable)
//using System;

//interface IWalkable
//{
//    void Walk();
//}

//class Robot : IWalkable
//{
//    public void Walk()
//    {
//        Console.WriteLine("Robot is walking in its default mode.");
//    }

//    void IWalkable.Walk()
//    {
//        Console.WriteLine("Robot is walking as per IWalkable implementation.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Robot robot = new Robot();

//        robot.Walk();

//        IWalkable walkableRobot = robot;
//        walkableRobot.Walk();
//    }
//}



//How does explicit interface implementation help in resolving naming conflicts?

//Method Name Conflict Resolution:
//If a class and an interface both define methods with the same name, explicit interface implementation ensures that the class's method and the interface's method are treated separately.
//Fine-Grained Control:
//Explicit implementation allows a class to provide specialized behavior for interface methods while keeping its own methods distinct and accessible.
//Encapsulation of Interface Methods:
//Interface methods implemented explicitly are not accessible via the class instance directly; they are accessible only through the interface reference. This reduces the chances of unintentional misuse.
//Polymorphic Behavior:
//Explicit implementation allows the interface's behavior to differ from the default behavior of the class, supporting polymorphism.


#endregion

#region Task 6: Implementing IDisposable (Resource)
//using System;

//struct Account
//{
//    private int accountId;
//    private string accountHolder;
//    private double balance;

//    public int AccountId
//    {
//        get { return accountId; }
//        set { accountId = value; }
//    }

//    public string AccountHolder
//    {
//        get { return accountHolder; }
//        set { accountHolder = value; }
//    }

//    public double Balance
//    {
//        get { return balance; }
//        set
//        {
//            if (value >= 0)
//                balance = value;
//            else
//                throw new ArgumentException("Balance cannot be negative.");
//        }
//    }

//    public Account(int id, string holder, double initialBalance)
//    {
//        accountId = id;
//        accountHolder = holder;
//        balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Balance cannot be negative.");
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Account ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Account account = new Account(101, "John Doe", 5000);

//        account.Display();

//        account.Balance = 7000;
//        Console.WriteLine("After updating balance:");
//        account.Display();

//        try
//        {
//            account.Balance = -100; 
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}

//What is the key difference between encapsulation in structs and classes?

//Value Type vs. Reference Type:

//A struct is a value type, meaning it is stored on the stack, and copies are independent of each other. A class is a reference type, stored on the heap, and references point to the same memory location.
//Default Constructor:

//Structs do not support parameterless constructors, while classes can have both parameterless and parameterized constructors.
//Performance:

//Structs are lightweight and ideal for small data types that do not require inheritance, while classes are better for complex objects.
//Encapsulation in Structs:

//Structs can encapsulate data using private fields and public properties, just like classes, but because they are value types, any modifications to a struct are made to a copy unless passed by reference.

#endregion

#region Task 7: Abstraction and Encapsulation
//using System;

//abstract class Vehicle
//{
//    public abstract void StartEngine(); 
//    public abstract void StopEngine();  

//    public void DisplayMessage(string message)
//    {
//        Console.WriteLine(message);
//    }
//}

//class Car : Vehicle
//{
//    private string carName; 
//    public string CarName
//    {
//        get { return carName; }
//        set { carName = value; }
//    }

//    public override void StartEngine()
//    {
//        DisplayMessage($"{CarName}: Engine started.");
//    }

//    public override void StopEngine()
//    {
//        DisplayMessage($"{CarName}: Engine stopped.");
//    }
//}

//class Bike : Vehicle
//{
//    private string bikeName; 

//    public string BikeName
//    {
//        get { return bikeName; }
//        set { bikeName = value; }
//    }

//    public override void StartEngine()
//    {
//        DisplayMessage($"{BikeName}: Engine started.");
//    }

//    public override void StopEngine()
//    {
//        DisplayMessage($"{BikeName}: Engine stopped.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car { CarName = "Tesla Model 3" };
//        Bike bike = new Bike { BikeName = "Yamaha R15" };

//        car.StartEngine();
//        car.StopEngine();

//        bike.StartEngine();
//        bike.StopEngine();
//    }
//}

//Abstraction:

//The Vehicle class is abstract and defines methods(StartEngine, StopEngine) that derived classes must implement.
//The DisplayMessage method is a non-abstract method shared across all derived classes.
//Encapsulation:

//The private fields carName and bikeName are accessed and modified through public properties CarName and BikeName.

#endregion

#region Task 8: Default Interface Implementation (ILogger)
//using System;

//interface ILogger
//{
//    void Log()
//    {
//        Console.WriteLine("Default logger: Logging message...");
//    }
//}

//class ConsoleLogger : ILogger
//{
//    public void Log()
//    {
//        Console.WriteLine("Console logger: Logging message...");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ILogger defaultLogger = new DefaultLogger();
//        ILogger consoleLogger = new ConsoleLogger();

//        defaultLogger.Log(); 
//        consoleLogger.Log();   
//    }
//}

//class DefaultLogger : ILogger { }



//How do default interface implementations affect backward compatibility in C#?

//Backward Compatibility:
//Before C# 8.0, adding a new method to an interface would break all implementing classes unless they implemented the new method.
//Default implementations allow interfaces to evolve by adding new methods with predefined behavior, without breaking existing implementations.
//Optional Override:
//Implementing classes can either rely on the default implementation or provide their own specific implementation by overriding the method.
//Simplified Upgrades:
//Default implementations reduce the need for utility base classes since common functionality can now be directly implemented in the interface itself.

#endregion

#region Task 9: Constructor Overloading
//using System;

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }

//    public Book()
//    {
//        Title = "Unknown Title";
//        Author = "Unknown Author";
//    }

//    public Book(string title)
//    {
//        Title = title;
//        Author = "Unknown Author";
//    }

//    public Book(string title, string author)
//    {
//        Title = title;
//        Author = author;
//    }

//    public void DisplayBookInfo()
//    {
//        Console.WriteLine($"Title: {Title}, Author: {Author}");
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Book book1 = new Book();
//        book1.DisplayBookInfo();

//        Book book2 = new Book("1984");
//        book2.DisplayBookInfo();

//        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee");
//        book3.DisplayBookInfo();
//    }
//}


//How Constructor Overloading Improves Class Usability

//Flexibility: It allows users of the class to create objects with different levels of information.
//You can create an object with just a title if the author is unknown, or both title and author if both pieces of information are available.
//This prevents the need for unnecessary parameters or setting properties after object creation.

//Convenience: By providing multiple constructors, you reduce the need for users to manually set values after object creation.
//This makes the class easier to use in different scenarios and improves the readability of the code.

//Code Maintenance: Constructor overloading simplifies code maintenance.
//Rather than checking for null or assigning default values for missing data,
//different constructors can automatically handle various input scenarios.

//Clear Intent: It clarifies the intentions of the object instantiation.
//For example, if you only need a title and the author is optional,
//using a constructor that only accepts a title makes it clear to anyone reading the code that only the title is important in that context.
#endregion



#region part 2

#region the first task
//public interface IShapeSeries
//{
//    int CurrentShapeArea { get; set; }
//    void GetNextArea();
//    void ResetSeries();
//}


//public class SquareSeries : IShapeSeries
//{
//    public int CurrentShapeArea { get; set; }
//    private int sideLength;

//    public SquareSeries()
//    {
//        sideLength = 1;
//        CurrentShapeArea = sideLength * sideLength;
//    }

//    public void GetNextArea()
//    {
//        sideLength++;
//        CurrentShapeArea = sideLength * sideLength;
//    }

//    public void ResetSeries()
//    {
//        sideLength = 1;
//        CurrentShapeArea = sideLength * sideLength;
//    }
//}
//public class CircleSeries : IShapeSeries
//{
//    public int CurrentShapeArea { get; set; }
//    private int radius;

//    public CircleSeries()
//    {
//        radius = 1;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }

//    public void GetNextArea()
//    {
//        radius++;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }

//    public void ResetSeries()
//    {
//        radius = 1;
//        CurrentShapeArea = (int)(Math.PI * radius * radius);
//    }
//}

#endregion

#region the second task
//public static void PrintTenShapes(IShapeSeries series)
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine("Shape Area: " + series.CurrentShapeArea);
//        series.GetNextArea();
//    }
//}
#endregion

#region the third task
//public class Shape : IComparable<Shape>
//{
//    public string Name { get; set; }
//    public double Area { get; set; }

//    public Shape(string name, double area)
//    {
//        Name = name;
//        Area = area;
//    }

//    public int CompareTo(Shape other)
//    {
//        if (this.Area < other.Area)
//            return -1;
//        else if (this.Area > other.Area)
//            return 1;
//        else
//            return 0;
//    }
//}


#endregion

#region the fourth task
using System.Drawing;

public static void SortShapesByArea()
{
    List<Shape> shapes = new List<Shape>
    {
        new Shape("Square", 25),
        new Shape("Circle", 78.54),
        new Shape("Rectangle", 40)
    };

    // Sort shapes by area using IComparable
    shapes.Sort();

    foreach (var shape in shapes)
    {
        Console.WriteLine($"Shape: {shape.Name}, Area: {shape.Area}");
    }
}

#endregion

#region the fifth task
//public abstract class GeometricShape
//{
//    public double Dimension1 { get; set; }
//    public double Dimension2 { get; set; }

//    // Abstract method to calculate the area
//    public abstract double CalculateArea();

//    // Abstract property for perimeter
//    public abstract double Perimeter { get; }
//}
#endregion

#region the sixth task
//public class Triangle : GeometricShape
//{
//    public override double CalculateArea()
//    {
//        return 0.5 * Dimension1 * Dimension2;
//    }

//    public override double Perimeter => Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); // Hypotenuse formula
//}

//public class Rectangle : GeometricShape
//{
//    public override double CalculateArea()
//    {
//        return Dimension1 * Dimension2;
//    }

//    public override double Perimeter => 2 * (Dimension1 + Dimension2);
//}

#endregion

#region the seventh task
//public static void DisplayGeometricShapes()
//{
//    GeometricShape triangle = new Triangle { Dimension1 = 3, Dimension2 = 4 };
//    GeometricShape rectangle = new Rectangle { Dimension1 = 5, Dimension2 = 10 };

//    Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.Perimeter}");
//    Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.Perimeter}");
//}

#endregion

#region the eighth task
//public static void SelectionSort(int[] numbers)
//{
//    int n = numbers.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        int minIndex = i;
//        for (int j = i + 1; j < n; j++)
//        {
//            if (numbers[j] < numbers[minIndex])
//            {
//                minIndex = j;
//            }
//        }
//        // Swap the found minimum element with the first element
//        int temp = numbers[minIndex];
//        numbers[minIndex] = numbers[i];
//        numbers[i] = temp;
//    }
//}

#endregion

#region the ninth task
//public static void SortShapeAreas()
//{
//    int[] shapeAreas = { 25, 78, 40, 100, 12 }; // Example areas
//    SelectionSort(shapeAreas);

//    Console.WriteLine("Sorted Areas:");
//    foreach (var area in shapeAreas)
//    {
//        Console.WriteLine(area);
//    }
//}
#endregion


#endregion