using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Vector;

public class Vector<T>
{
    private T[] container;

    public Vector()
    {
        this.container = new T[] {};
    }

    public T At(int index) => (index < 0) ? (this.container[this.container.Length + index - 1]) : (this.container[index]);

    public void PushBack(T element) => this.container[this.container.Length] = element;
    public void PopBack() => this.container.SetValue(null, this.container.Length);
    
    public T this[int key]
    {
        get => this.container[key];
        set => this.container[key] = value;
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
}