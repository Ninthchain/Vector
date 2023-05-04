
<p id="SinglePushBack">Vector&lt;T&gt.PushBack(T element)</p>

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