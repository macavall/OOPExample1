namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            // ================================================
            // ================================================
            // Create 2 instances of MyClass and
            // Configuring values in myClass objects
            // ================================================
            // ================================================

            // Way 1
            var myClass = new MyClass();
            myClass.MyClassProperty = "MyClass1Property";
            myClass.MyClassField = "MyClass1Field";

            // Way 2
            var myClass2 = new MyClass ()
            { 
                MyClassProperty = "MyClass2Property", 
                MyClassField = "MyClass2Field" 
            };

            // ================================================
            // ================================================
            // Adding 3 MyClass objects to the list
            // ================================================
            // ================================================

            // Creating List of type MyClass
            List<MyClass> myClassList = new List<MyClass>();

            myClassList.Add(myClass);
            myClassList.Add(myClass2);

            // Call the MyClassMethodFieldProperty Method for each class in the list myClassList
            foreach(var myClassItem in myClassList)
            {
                myClassItem.MyClassMethodFieldProperty();
            }

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
