namespace OtusStack;

public class Stack
{
    private StackItem? _top;

    public Stack(params string[] elements)
    {
        foreach (var element in elements) Add(element);
    }

    public string? Top => Size > 0 ? _top?.Data : null;

    public int Size { get; private set; }

    public void Add(string? newElement)
    {
        var temp = new StackItem
        {
            Data = newElement,
            Next = _top
        };
        _top = temp;
        Size++;
    }

    public string? Pop()
    {
        var temp = _top;
        if (Top == null || Size == 0)
            throw new InvalidOperationException("Can't do Pop operation. Stack is empty");
        _top = temp?.Next;
        Size--;
        return temp?.Data;
    }

    public static Stack Concat(params Stack[] stacks)
    {
        var stack = new Stack();
        foreach (var s in stacks)
        {
            var sSize = s.Size;
            for (var i = 0; i < sSize; i++) stack.Add(s.Pop());
        }

        return stack;
    }

    private class StackItem
    {
        public string? Data { get; init; }

        public StackItem? Next { get; init; }
    }
}