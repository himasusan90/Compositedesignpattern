// See https://aka.ms/new-console-template for more information
public class Number : IArithematicExpression
{
    public int Value { get; set; }
    public Number(int value)
    {
        Value=value;
    }
    public int Evaluate()
    {
        Console.WriteLine( "Number is " + Value);
        return Value;
    }
}
