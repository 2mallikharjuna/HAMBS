public class Counter
{
    private int increment;
    private int counter = 0;
    private string prefix;

    public Counter(int increment, string prefix)
    {
        this.increment = increment;
        this.prefix = prefix;
    }

    // Method to get the incremented value of the counter
    public int GetIncrement()
    {
        counter += increment;
        return counter;
    }

    public string GetPrefix()
    {
        return prefix;
    }
}

public class DocumentCounter
{
    private Counter counter;

    public DocumentCounter(string prefix, int increment)
    {
        counter = new Counter(increment, prefix);
    }

    public string GetDocumentAndPrefix()
    {
        int updatedCounter = counter.GetIncrement();
        string prefix = counter.GetPrefix();
        return $"{prefix}-{updatedCounter}";
    }
}
