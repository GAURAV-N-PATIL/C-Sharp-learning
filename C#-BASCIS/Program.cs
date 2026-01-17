using System; //this means we are using class from the system namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_BASCIS //namespace is used to organize code and is a container for classes and other namespaces
{
    public class Program //class is conatiner for data and methods,which brings functionality to the program
    {
        static void Main(string[] args)
        {
            //C# is a programming language developed by Microsoft that runs on the .NET Framework.
            //it is used to developed web apps, desktop apps, mobile apps, games and more.
            //it is Object Oriented Programming Language. It is close to C++ and Java.
            Console.WriteLine("Hello, World!");
            Console.WriteLine("THIS FOR BASIC LEARNINGS");
            Console.Write("Press Enter to exit...");
            Console.Write("this looks like two attached lines bcz i used Write instead of WriteLine");
            /*difference between write and write line is writeline moves the cursor to
            the next line after writing the output where as write keeps the cursor on the same line.*/
            //Unlike C you can use int without declaring it first in variable declaration. just use int directly.
            //e.g.:
            Console.WriteLine("");
            Console.WriteLine(5 + 6);
            //here i don't need to declare int a=5; int b=6; before using them in addition.
            //and also don't need to use variable name in Console.WriteLine() method. like in C we do printf("%d",a+b);

            //C# variables and data types:
            /*
             * 1. int - stores integers (whole numbers) without decimals, e.g., 1, -5, 42
             * 2. double - stores floating-point numbers (numbers with decimals), e.g., 3.14, -0.001
             * 3. float - stores floating-point numbers with less precision than double, e.g., 3.14f
                  generally used when memory is a concern.
             * 4. decimal - stores high-precision decimal numbers, often used for financial calculations, e.g., 19.99m
             * 5. long - stores large integers, e.g., 9223372036854775807
             * 6. short - stores small integers, e.g., 32767
             * 7. byte - stores very small integers (0 to 255), e.g., 255
             * 8. sbyte - stores very small integers (-128 to 127), e.g., 127
             * 9. uint - stores non-negative integers, e.g., 4294967295
             * 10. ulong - stores large non-negative integers, e.g., 18446744073709551615
             * 11. ushort - stores small non-negative integers, e.g., 65535
             * 12. char - stores a single character, e.g., 'A', 'b', '1'
             * 13. string - stores a sequence of characters (text), e.g., "Hello, World!"
             * 14. bool - stores a boolean value, either true or false
             * 15. object - the base type from which all other types derive; can store any data type
             * 16. var - implicitly typed variable, the type is determined by the compiler at runtime based on the assigned value
             * 17. dynamic - similar to var, but the type can change at runtime
             * 18. DateTime - stores date and time values
             * 19. TimeSpan - stores a time interval
             * 20. enum - a special "value type" that allows you to define a set of named constants
             * 21. struct - a value type that can encapsulate data and related functionality in more simple term it is like a container which allows you to group related variables of same type together
             * 22. nullable types - allows value types to represent null values, e.g., int?, double?
             * 23. arrays - a collection of items of the same type, e.g., int[], string[]
             * 24. List<T> - a generic collection that can store a variable number of items of a specified type
             * 25. Dictionary<TKey, TValue> - a collection of key-value pairs
             * 26. Tuple - a data structure that can hold a fixed number of items of different types
             * 27. dynamic - a type that bypasses compile-time type checking
             */
            /*
             'int', 'long', 'short', 'byte' → all integers, just different sizes
             'float', 'double', 'decimal' → all decimals, different precision
             'char' vs 'string' → single character vs text
             'struct', 'class' → object-oriented programming
             'enum' → symbolic values
             'nullable' types (int?) → memory and null handling
             'Span<T>', 'ReadOnlySpan<T>' → performance and memory safety
            */
            //IMPORTANT DATA TYPES YOU NEED NOW: 'int', 'double', 'char', 'string', 'bool'
            int myInt; //for declearing variables write variable type followed by variable name
            myInt=10; //for initializing variable use '=' operator followed by value
            double myDouble = 5.99;   // We can do declearation and initialization in single line
            char myChar = 'A';
            string myString = "Hello";
            bool myBool = true;
            Console.WriteLine("Integer: " + myInt);
            //Constants in C#:
            const double PI = 3.14159; //constant variable declaration using 'const' keyword before variable type
            //if you try to change the value of PI later in the code it will give error
            //for displaying Strings, variables values we can use '+' operator to concatenate them
            Console.WriteLine("Constant PI: " + PI);
            //here Constant PT is string and PI is double but '+' operator can concatenate them without any issue.
            Console.WriteLine(5 + myInt);
            Console.WriteLine("integer:" + myInt + 10)
            /*this will print integer:1010 bcz '+' operator concatenates myInt value(10) with 10 as string.
            i.e due to concatenation integer:10 will be consider as string 
            and then 10 will be concatenated to it resulting in integer:1010*/
            //this is called operator overloading where same operator behaves differently based on context.
            Console.WriteLine("integer:" + (myInt + 10));
            //this will print integer:20 bcz due to paranthesis and presidency level parathesis will be solve first then concatenation will happend with string
            //i.e if both are string it will combine them and if both are numeric both will get add
            //if one is string and one is numeric it will still combine them
            //by this we can understand different nature of " + " operator.

            Console.ReadLine();
        }
    }
}
