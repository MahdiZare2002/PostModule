namespace PostModule.Domain.PostEntity.ValueObjects;

public class WeightRange
{
    public int Start { get; private set; }
    public int End { get; private set; }

    public WeightRange(int start, int end)
    {
        if (start < 0 || end <= start)
            throw new ArgumentException("Invalid weight range");

        Start = start;
        End = end;
    }
}