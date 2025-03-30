namespace OtusStack;

public class StackOld(params string[] elements)
{
    private readonly List<string?>? _stack = [..elements];

    public string? Top => _stack is { Count: 0 } ? null : _stack?[^1];
    public int Size => _stack?.Count ?? 0;

    public string? Pop()
    {
        var lastElement = Top;
        if (_stack == null || _stack.Count == 0)
            throw new InvalidOperationException("Can't do Pop operation. Stack is empty");
        _stack.RemoveAt(_stack.Count - 1);
        return lastElement;
    }

    public void Add(string? newElement)
    {
        _stack?.Add(newElement);
    }

    public static StackOld Concat(params StackOld[] stacks)
    {
        var stack = new StackOld();
        foreach (var s in stacks)
        {
            var sSize = s.Size;
            for (var i = 0; i < sSize; i++) stack.Add(s.Pop());
        }

        return stack;
    }
}