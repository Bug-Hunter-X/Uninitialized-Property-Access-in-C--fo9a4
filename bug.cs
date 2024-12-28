public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that has not been initialized
        int value = MyProperty; 
        Console.WriteLine(value); // This will print 0
    }
}