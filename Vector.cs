using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Vector;

public class Vector<T>
{
    private IEnumerator enumerator;
    
    private T[] container;
    
    
    public Vector(T[] elements = default)
    {
        this.container = elements is null ? Array.Empty<T>() : elements;
    }

    public void PushBack(T element)
    {
        Array.Resize(ref this.container, this.container.Length + 1);
        this.container[^1] = element;
    }

    public void PushBack(Vector<T> elementRange)
    {
        Array.Resize(ref this.container, elementRange.Size());
        for (int i = 0; i < elementRange.Size(); i++)
            this.PushBack(elementRange[i]);
    }

    public void PopBack() => Array.Resize(ref this.container, this.container.Length - 1);
    
    public T this[int key]
    {
        get => this.container[key];
        set => this.container[key] = value;
    }

    public int Size()
    {
        return this.container.Length;
    }

    public Vector<T> GetRange(int begin, int end, Predicate<T>? filter = null)
    {
        Vector<T> result = new Vector<T>();
        
        for (int i = begin; i < end; i++)
        {
            if (filter is null)
            {
                result.PushBack(this[i]);
                continue;
            }
            if(filter(this[i]))
                result.PushBack(this[i]);
        }

        return result;
    }

    public ref T[] ToArray()
    {
        return ref this.container;
    }
}