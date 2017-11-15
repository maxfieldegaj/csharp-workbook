using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        // Instanciate Stack Class
        Stack myStack = new Stack();

        try
        {
        myStack.Push("Max");
        myStack.Push(676767);
        myStack.Push(DateTime.Now);
        myStack.Push(true);
        myStack.Push(null); // exception
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        

        Console.WriteLine(myStack.Pop()); // true
        Console.WriteLine(myStack.Pop()); // datetime
        Console.WriteLine(myStack.Pop()); // 676767
        Console.WriteLine(myStack.Pop()); // "MaX"
   //     Console.WriteLine(myStack.Pop()); // Exception
        Console.ReadLine();
	}
}
public class Stack
{
    // Properties
    List<object> Lifo { get; set; }

    // Constructor
    public Stack()
    {
        Lifo = new List<object>();
    }

    // Methods

    // push
    public void Push(object obj)
    {
        // check if object is null and if so throw an exception
        if (obj == null)
        {
            throw new InvalidOperationException("Cannot pass a NULL value into the list!");

        }
            Lifo.Add(obj);
        
    }

    // pop
    public object Pop()
    {
        // throw exception if POP() when stack is already empty
        if (Lifo.Count == 0)
        {
            throw new InvalidOperationException("LIFO List is already empty. Cannot remove what does not exist!");
        }
        int indexOfLast = Lifo.Count -1; // zero based index
        object cloned = Lifo[indexOfLast];

        Lifo.RemoveAt(indexOfLast);
        return cloned;
        
    }


    // clear - remove all elements from the list   
    public void Clear()
    {
        Lifo.Clear();
    }

}