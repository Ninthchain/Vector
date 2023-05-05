<head>
    <title>Examples</title>
</head>

<h1>Examples</h1>

<div style="margin: 100px; width: 300px; height: auto">


<h4>Hooray!!! Examples!</h4>
<img src="https://media3.giphy.com/media/Ws6T5PN7wHv3cY8xy8/giphy.gif?cid=ecf05e472tz5pee4f3ahm050ucts9eh8wwx85lgimerb85bc&ep=v1_gifs_search&rid=giphy.gif&ct=g" alt="Gif hasn't been found( This file would be not so fun :|">
</div>

<h1></h1>

<h5 id="SinglePushBack">void PushBack(T element)</h5>
```csharp
    //Initializing
    Vector<int> numbers = new Vector<int>();
    
    //Adding elements
    numbers.PushBack(10);
    numbers.PushBack(12);
    numbers.PushBack(30);
    
    // Writing result
    Console.WriteLine($"Result: {String.Join(", ", numbers.ToArray()}")
    
    //Output: Result: 10, 12, 30
```
<h1></h1>
<h5 id="RangePushBack">void PushBack(Vector&lt;T&gt; elementsRange)</h5>

```csharp
    //Initializing
    Vector<string> arr = new Vector<int>(new string[] {"I", "am"});
    Vector<string> range = new Vector<int>(new string[] {"a", "supercoder!"})
    
    //Pushing back the range
    arr.PushBack(range);
    
    //Writing result
    Console.WriteLine(String.Join(" ", arr);
    
    //Output: I am a supercoder!
```
<h1></h1>
<h5 id="GetRange">Vector&lt;T&gt; GetRange(int begin, int end, Predicate&lt;T&gt;? filter)</h5>

```csharp
Random random = new Random();

// Initializing array with 1000 of random elements
Vector<int> numbers = new Vector<int>(Enumerable.Repeat(0, 1000).Select(i => random.Next(0, Int32.MaxValue)).ToArray());

Vector<int> range = numbers.GetRange(100, 200);

//Okay let's do something with this range


// ------------------------------------Sorting with .NET framework methods----------------------------------------------
Console.WriteLine($"Before sorting: {String.Join(", ", range.ToArray())}");


Array.Sort(range.ToArray());

Console.WriteLine($"\n\nAfter sorting: {String.Join(", ", range.ToArray())}");


// Now lets take range of THIS sorted range. And make some filter that number must be even.

Vector<int> evenRange = range.GetRange(0, (range.Size() -1) / 2, number => number % 2 == 0);

// And also want to sort it. So before output will sort this
Array.Sort(evenRange.ToArray());
    
Console.WriteLine($"Sorted even range: {String.Join(", ", evenRange.ToArray())}");
// ---------------------------------------------------------------------------------------------------------------------

// Use your imagination! Write something for yourself. I am interested in any realization of my Vector
```