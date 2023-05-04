<h1>Examples</h1>

<h4>Hooray!!! Examples!</h4>
<img src="https://media3.giphy.com/media/Ws6T5PN7wHv3cY8xy8/giphy.gif?cid=ecf05e472tz5pee4f3ahm050ucts9eh8wwx85lgimerb85bc&ep=v1_gifs_search&rid=giphy.gif&ct=g">

<h1></h1>

<h5 id="SinglePushBack">PushBack(T element)</h5>
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
<h5 id="RangePushBack">PushBack(Vector&lt;T&gt; elementsRange)</h5>

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