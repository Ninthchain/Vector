using Vector;

Vector<int> arr = new Vector<int>(new int[] {1, 2, 3, 4});

Vector<int> range = arr.GetRange(0, arr.Size(), x => x % 2 == 0);

for (int i = 0; i < range.Size(); i++)
    Console.WriteLine(range[i]);

