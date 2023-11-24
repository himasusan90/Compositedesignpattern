// See https://aka.ms/new-console-template for more information

//2*(1+7)

//      *
//  /       \
//  2        +
//          /  \
//         1    7
IArithematicExpression two = new Number(2);
IArithematicExpression one = new Number(1);
IArithematicExpression seven = new Number(7);
IArithematicExpression exp1 = new Expression(one, seven, Operation.ADD);
IArithematicExpression exp2 = new Expression(two, exp1, Operation.MULTIPLY);
Console.WriteLine( exp2.Evaluate());

