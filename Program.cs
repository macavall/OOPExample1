namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var myClass = new MyClass();

            // Creating List of type MyClass
            List<MyClass> myClassList = new List<MyClass>();

            // Adding 3 MyClass objects to the list
            // 2 ways of doing this

            // Way 1
            myClass.MyClassProperty = "MyClass1Property";
            myClass.MyClassField = "MyClass1Field";

            // Way 2
            myClassList.Add(new MyClass 
            { 
                MyClassProperty = "MyClass1Property", 
                MyClassField = "MyClass1Field" 
            });

            Console.ReadLine();
        }

        public class MyClass
        {
            public string? MyClassProperty { get; set; }

            public string? MyClassField;

            public void MyClassMethod()
            {
                Console.WriteLine("Hello from MyClassMethod!");
            }

            // write to console property and field
            public void MyClassMethodFieldProperty()
            {
                Console.WriteLine($"MyClass Property value is: {MyClassProperty}");
                Console.WriteLine($"MyClass Field value is: {MyClassField}");
            }
        }
    }
}
