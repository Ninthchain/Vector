//The file which is showing features of my array


//Getting range of elements by begin index and end index without filter

using Vector;


Random random = new Random();

// Initializing array with 1000 of random elements
Vector<int> numbers = new Vector<int>(Enumerable.Repeat(0, 1000).Select(i => random.Next(0, Int32.MaxValue)).ToArray());

Vector<int> range = numbers.GetRange(100, 200);

//Okay let's do something with this range


// ------------------------------------Sorting with .NET framework methods----------------------------------------------
Console.WriteLine($"Before sorting: {String.Join(", ", range.ToArray())}");


Array.Sort(range.ToArray());

Console.WriteLine($"\n\nAfter sorting: {String.Join(", ", range.ToArray())}");


// Now lets take range of this sorted range. And make some filter that number must be even.

Vector<int> evenRange = range.GetRange(0, (range.Size() -1) / 2, number => number % 2 == 0);

// And also want to sort it. So before output will sort this
Array.Sort(evenRange.ToArray());
    
Console.WriteLine($"Sorted even range: {String.Join(", ", evenRange.ToArray())}");
// ---------------------------------------------------------------------------------------------------------------------

// Use your imagination! Write something for yourself. I am interested in any realization of my Vector