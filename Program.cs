namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================================================
            // ================================================
            // Create 2 instances of MyClass and
            // Configuring values in myClass objects
            // ================================================
            // ================================================

            // Way 1
            // Creating and configuring myClass object in variable myClass

            var myClass = new MyClass();
            myClass.MyClassProperty = "MyClass1Property";
            myClass.MyClassField = "MyClass1Field";

            // Way 2
            // Creating and configuring myClass object in variable myClass2
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

            Console.WriteLine("================================================");
            Console.WriteLine("Looping through classes in myClassList and calling MyClassMethodFieldProperty");
            Console.WriteLine();
            Console.WriteLine();

            // Call the MyClassMethodFieldProperty Method for each class in the list myClassList
            // Initialize the iteration count
            int iterationCount = 0;

            foreach (var myClassItem in myClassList)
            {
                // console.writeline the variable name of class
                Console.WriteLine($"MyClass iteration#: {iterationCount}");
                myClassItem.MyClassMethodFieldProperty();
                iterationCount = iterationCount + 1; // Can also use iterationCount++
                Console.WriteLine();
            }

            Console.WriteLine("================================================");

            // show how many classes have the string "1" contained in the property or field
            // Notice the green squiggly line, this is because the property or field could be null
            // This is not good practice, as it could cause a null reference exception
            Console.WriteLine("Using nullable values that could cause exceptions");
            Console.WriteLine($"Classes Count from list with 1 in the property or field: {myClassList.Count(x => x.MyClassProperty.Contains("1") || x.MyClassField.Contains("1"))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");

            // Better method to ensure there is not a failure for a null value in property or field

            // Better method to ensure there is not a failure for a null value in property or field
            // Check if the property or field is null
            Console.WriteLine("Using nullable values that will not cause exceptions");
            Console.WriteLine($"Classes Count from list with 1 in the property or field: {myClassList.Count(x => (x.MyClassProperty != null && x.MyClassProperty.Contains("1")) || (x.MyClassField != null && x.MyClassField.Contains("1")))}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("================================================");

            // The more readable version of this, my personal preference

            iterationCount = 0;
            foreach (var myClassItem in myClassList)
            {
                // console.writeline the name of the class
                Console.WriteLine($"MyClass iteration#: {iterationCount}");

                if (myClassItem.MyClassProperty != null)
                {
                    if (myClassItem.MyClassProperty.Contains("1"))
                    {
                        Console.WriteLine($"MyClass Iteration {iterationCount} contains Property with the string  \"1\"");
                        Console.WriteLine($"MyClass Property value is: {myClassItem.MyClassProperty}");
                    }
                    else
                    {
                        Console.WriteLine($"MyClass Iteration {iterationCount} does not contain Property with the string  \"1\"");
                    }
                }
                else
                {
                    Console.WriteLine("MyClass Property is null");
                }

                if (myClassItem.MyClassField != null)
                {
                    if (myClassItem.MyClassField.Contains("1"))
                    {
                        Console.WriteLine($"MyClass Iteration {iterationCount} contains Field with the string  \"1\"");
                        Console.WriteLine($"MyClass Field value is: {myClassItem.MyClassField}");
                    }
                    else
                    {
                        Console.WriteLine($"MyClass Iteration {iterationCount} does not contain Field with the string  \"1\"");
                    }
                }
                else
                {
                    Console.WriteLine("MyClass Property is null");
                }

                iterationCount = iterationCount + 1; // also can use iterationCount++
                Console.WriteLine();
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

            // Write to console property and field
            public void MyClassMethodFieldProperty()
            {
                Console.WriteLine($"MyClass Property value is: {MyClassProperty}");
                Console.WriteLine($"MyClass Field value is: {MyClassField}");
            }
        }
    }
}
