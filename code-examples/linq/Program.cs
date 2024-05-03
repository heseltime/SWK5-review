List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

// Query Syntax
var evenNumbersQuery = from num in numbers
                       where num % 2 == 0
                       select num;

Console.WriteLine("Even Numbers (Query Syntax):");
foreach (var num in evenNumbersQuery)
{
    Console.WriteLine(num);
}

// Method Syntax
var evenNumbersMethod = numbers.Where(num => num % 2 == 0);

Console.WriteLine("\nEven Numbers (Method Syntax):");
foreach (var num in evenNumbersMethod)
{
    Console.WriteLine(num);
}