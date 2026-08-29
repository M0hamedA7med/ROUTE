using Assignment;

//first one 
Book book = new Book("Asp.Net Basics", 400);
object obj = book;
Console.WriteLine(obj);


//second one 
Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetHashCode());
Console.WriteLine(book.GetType());


//third one 

//Error type: Compile-time errorConsole.WriteLine("Explanation: Cannot assign a string literal to an integer variable.");
int pagesFix = 464;



//number four
try
{
    int zero = 0;
    int result = 10 / zero;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}

//number 5
int pages = 300;
double doublePages = pages;
Console.WriteLine($"Implicit conversion (double): {doublePages}");


