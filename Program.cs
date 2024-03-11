using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var myClass = new MyClass();

            Console.WriteLine("Writing out the values for MyClassProperty and MyClassField in that order: ");

            myClass.MyClassProperty = "Hello from MyClassProperty!";
            myClass.MyClassField = "Hello from MyClassField!";

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Executing MyClass Methods: ");

            myClass.MyClassMethod();
            myClass.MyClassMethodFieldProperty();

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
