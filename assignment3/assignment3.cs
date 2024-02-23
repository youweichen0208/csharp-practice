class Assignment3
{
    public static void Main()
    {
        //Below is the code for question 1. Uncomment it to run them
        Console.WriteLine("Below is the answer for question Reverse Content:");
        var length = 15;
        var num = ReverseContent.GenerateNumbers(length);
        Console.Write("Before reverse: ");
        ReverseContent.PrintNumbers(num);
        ReverseContent.Reverse(num);
        Console.Write("After reverse: ");
        ReverseContent.PrintNumbers(num);

        //Below is the code for question 2 Fibonacci. Uncomment it to run them 
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question Fibonacci Sequence:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Fibonacci({i}): {FibonacciSequence.Fibonacci(i)}");
        }

        // Below is the code for Designing and Building Classes using object-oriented principle
        // answer for question 1:
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question 1 in Designing and Building classes:");
        Dog corgi = new Corgi();
        Dog teddy = new Teddy();
        corgi.Bark();
        teddy.Bark();

        //Below is the code for question 2. Uncomment below to run the answer:
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question 2:");
        Person student = new Student();
        Person instructor = new Instructor();
        student.PrintIdentity();
        instructor.PrintIdentity();
        
        
        //Below is the code for question 3. 
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question 3:");
        var corgi2 = new Corgi();
        corgi2.Weight = 15;
        Console.WriteLine($"Accessing private field _weight in Dog class by using setter is {corgi2.Weight}");

        //Below is the code for question 4. Uncomment below to run the answer:
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question 4:");
        Person student2 = new Student();
        Person instructor2 = new Instructor();
        student2.PrintIdentity();
        instructor2.PrintIdentity();
        
        //Below is the code for question 5.
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question 5:");
        Employee worker = new Worker(50);
        Employee manager = new Manager(500, 10);
        Console.WriteLine($"Worker salary is {worker.CalculateSalary()}.");
        Console.WriteLine($"Manager salary is {manager.CalculateSalary()}.");
        
        // Code for question 6 is at line
        Console.WriteLine();
        Console.WriteLine("Code for Question 6 interface implementation is at line 236.");
        
        // code for question 7
        Console.WriteLine();
        Console.WriteLine("Below is the answer for question 7:");
        var smallSize = new Ball(5, new Color(255, 0, 0));
        var mediumSize = new Ball(10, new Color(0, 255, 0));
        var largeSize = new Ball(20, new Color(0, 0, 255));
        var superSize = new Ball(50, new Color(0, 0, 0, 30));
        
        smallSize.Throw();
        smallSize.Throw();
        smallSize.Pop();
        mediumSize.Throw();
        largeSize.Throw();
        largeSize.Throw();
        largeSize.Throw();
        largeSize.Throw();
        superSize.Throw();
        superSize.Throw();
        superSize.Throw();
        Console.WriteLine($"small size ball has thrown {smallSize.ThrowTimes} times.");
        Console.WriteLine($"medium size ball has thrown {mediumSize.ThrowTimes} times.");
        Console.WriteLine($"large size ball has thrown {largeSize.ThrowTimes} times.");
        Console.WriteLine($"super size ball has thrown {superSize.ThrowTimes} times.");

    }
}

public class ReverseContent
{
    public static int[] GenerateNumbers(int length)
    {
        var result = new int[length];
        for (var i = 0; i < length; i++)
        {
            var random = new Random();
            result[i] = random.Next(0, 100);
        }

        return result;
    }

    public static void PrintNumbers(int[] numbers)
    {
        for (var i = 0; i < numbers.Length; i++) Console.Write(numbers[i] + " ");
        Console.WriteLine();
    }

    public static void Reverse(int[] numbers)
    {
        var last = numbers.Length - 1;
        var mid = last / 2;
        for (var i = 0; i < mid; i++)
        {
            var temp = numbers[i];
            numbers[i] = numbers[last];
            numbers[last] = temp;
            last--;
        }
    }
}

public class FibonacciSequence
{
    public static int Fibonacci(int input)
    {
        if (input == 1 || input == 2)
            return 1;
        var table = new int[input];
        table[0] = 1;
        table[1] = 1;
        for (var i = 2; i < input; i++) table[i] = table[i - 1] + table[i - 2];

        return table[input - 1];
    }
}

public abstract class Dog
{
    public int Weight { get; set; }

    public abstract void Bark();
}

public class Corgi : Dog
{
    public override void Bark()
    {
        Console.WriteLine("Corgi bark!!!");
    }
}

public class Teddy : Dog
{
    public override void Bark()
    {
        Console.WriteLine("Teddy bark!!!");
    }
}


public abstract class Person
{
    public abstract void PrintIdentity();
}

public class Student : Person
{
    public override void PrintIdentity()
    {
        Console.WriteLine("I am a student.");
    }
}

public class Instructor : Person
{
    public override void PrintIdentity()
    {
        Console.WriteLine("I am an instructor.");
    }
}

public class Employee
{
    public String Name
    {
        get;
        set;
    }

    public virtual int CalculateSalary()
    {
        return 0;
    }
}

public class Worker : Employee
{
    private int _hour;
    private int _salary = 50;

    public Worker(int hour)
    {
        _hour = hour;
    }
    public override int CalculateSalary()
    {
        return _hour * _salary;
    }
}

class Manager : Employee
{
    private int _baseSalary;
    private int _bonus;

    public Manager(int baseSalary, int bonus)
    {
        _baseSalary = baseSalary;
        _bonus = bonus;
    }

    public override int CalculateSalary()
    {
        return _baseSalary + _bonus;
    }
    
}

// question 6. 
public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary(int val);
    List<string> GetAddresses();
}

public interface IInstructorService : IPersonService
{
    string Department();
    bool IsHeader();
    decimal CalculateBonus(decimal salary, DateTime joinDate);
}

public interface IStudentService : IPersonService
{
    List<string> Courses();
    double CalculateGPA(List<string> courses);
}

public interface ICourseService
{
    List<Student> EnrolledStudents();
}

public interface IDepartmentService
{
    string DepartmentHeaderName();
    decimal Budget(DateTime start, DateTime end);
    List<string> ProvidedCourses();
}

// question 7:
class Color
{
    public int Red { get; set;}
    public int Green { get; set; }
    public int Yellow { get; set; }
    public int Alpha { get; set; }

    public Color(int red, int green, int yellow, int alpha = 255)
    {
        Red = red;
        Green = green;
        Yellow = yellow;
        Alpha = alpha;
    }

    public int GrayScale()
    {
        return (Red + Green + Yellow) / 3;
    }
}

class Ball
{
    public int Size { get; set; }
    public int ThrowTimes { get; set; }
    public Color Color { get; set; }
    
    public Ball(int size, Color color)
    {
        ThrowTimes = 0;
        Size = size;
        Color = color;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size == 0)
        {
            Console.WriteLine("The ball cannot be thrown because the size is 0.");
        }
        else
        {
            ThrowTimes++;
        }
    }
}

