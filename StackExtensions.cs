namespace OtusStack;

public static class StackExtensions
{
    public static void Merge(this Stack s1, Stack s2)
    {
        var s2Size = s2.Size;
        for (var i = 0; i < s2Size; i++) s1.Add(s2.Pop());
    }
}