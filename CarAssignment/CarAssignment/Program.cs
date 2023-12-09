// See https://aka.ms/new-console-template for more information
using CarAssignment;
using System.Drawing;
using static CarAssignment.Point2D;

// question no.1 for Car
Car car = new Car("toyoto", 2023, 3000000);
Console.WriteLine("Car brand is :" + car.getBrand() + "\n, year is " + car.getYear() + "\n and price is " + car.getPrice());


// question no.2 for BankAccount
BankAccount bankAccount = new BankAccount("0007652783");
bankAccount.Depostit(1000);
bankAccount.WithDraw(500);
Console.WriteLine($"Your current balance after withdrawing is {bankAccount.getBalance()}");

// question no.3 for Rectangle
Rectangles rectangle = new Rectangles((float)4.5, (float)3.2);
Console.WriteLine($"Area is {rectangle.CalculateArea()}");

// question no.4 for Circle 
Circle circle = new Circle(5);
Console.WriteLine($"Calculated area is {circle.CalculateArea()}");

// question no.5 for Circle 
Student student = new Student("John Doe", 20, "Computer Science");
student.Introduce();

// question no.6 for Stack 
CarAssignment.Stack<int> intStack = new CarAssignment.Stack<int>();

Console.WriteLine("Is  stack empty? " + intStack.IsEmpty());

intStack.Push(1);
intStack.Push(2);
intStack.Push(3);

Console.WriteLine("Peeked item: " + intStack.Peek());
Console.WriteLine("Popped item: " + intStack.Pop());
Console.WriteLine("Is the stack empty? " + intStack.IsEmpty());

// question no.7 for Calender enum
Calender calender = new Calender();
calender.PrintWeekdays();


// question no.8 for equidistance
Point2D point1 = new Point2D(2.0f, 3.0f);
Point2D point2 = new Point2D(3.0f, 5.0f);

float distance = DistanceCalculator.CalculateDistance(point1, point2);

Console.WriteLine($"Distance apart from {point1} and {point2} is: {distance}");