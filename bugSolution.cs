public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    //Copy constructor to ensure a deep copy
    public MyClass(MyClass other)
    {
        this.MyProperty = other.MyProperty;
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(obj1); // Use copy constructor

        Console.WriteLine(obj1.MyProperty); //Output: 10
        Console.WriteLine(obj2.MyProperty); //Output: 10

        obj1.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); //Output: 20
        Console.WriteLine(obj2.MyProperty); //Output: 10
    }
}