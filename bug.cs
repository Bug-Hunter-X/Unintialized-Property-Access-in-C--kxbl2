public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that is not initialized can lead to unexpected behavior.
        int value = MyProperty; // Potential error if MyProperty is not set before this line
        Console.WriteLine(value);
    }
}