// See https://aka.ms/new-console-template for more information
public class Expression : IArithematicExpression
{
    public IArithematicExpression LeftExpression { get; set; }
    public IArithematicExpression RightExpression { get; set; }

    public Operation Operation { get; set; }

    public Expression(IArithematicExpression le, IArithematicExpression re,Operation o)
    {
        LeftExpression = le;
        RightExpression = re;
        Operation = o;
    }
    public int Evaluate()
    {
        int value=0;
        switch(Operation)
        {
            case Operation.ADD:
                value= LeftExpression.Evaluate()+ RightExpression.Evaluate(); break;
            case Operation.MULTIPLY:
                value = LeftExpression.Evaluate() * RightExpression.Evaluate(); break;
                default: return value;

        }
        Console.WriteLine( "value is "+ value );
        return value;
    }
}
