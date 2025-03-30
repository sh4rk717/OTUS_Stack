namespace OtusStack;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
        var s = new Stack("a", "b", "c");

        // size = 3, Top = 'c'
        Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

        var deleted = s.Pop();

        // Извлек верхний элемент 'c' Size = 2
        Console.WriteLine($"Извлек верхний элемент '{deleted}'. Size = {s.Size}");
        s.Add("d");

        // size = 3, Top = 'd'
        Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

        s.Pop();
        s.Pop();
        s.Pop();
        // size = 0, Top = null
        Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
        //s.Pop();  // здесь проверка исключения

        // Доп1
        var s1 = new Stack("a", "b", "c");
        s1.Merge(new Stack("1", "2", "3"));
        Console.WriteLine($"size = {s1.Size}, Top = '{s1.Top}'");
        var s1Size = s1.Size;
        for (var i = 0; i < s1Size; i++)
            Console.WriteLine(s1.Pop() + (i == 0 ? " - верхний" : i == s1Size - 1 ? " - нижний" : ""));

        // Доп2
        var s2 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
        Console.WriteLine($"size = {s2.Size}, Top = '{s2.Top}'");
        var s2Size = s2.Size;
        for (var i = 0; i < s2Size; i++)
            Console.WriteLine(s2.Pop() + (i == 0 ? " - верхний" : i == s2Size - 1 ? " - нижний" : ""));
    }
}