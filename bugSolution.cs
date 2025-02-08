public class MyClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass()
    {
        MyProperty = 0; // Initialize MyProperty with a default value
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty is guaranteed to have a value
        Console.WriteLine(value);
    }
}