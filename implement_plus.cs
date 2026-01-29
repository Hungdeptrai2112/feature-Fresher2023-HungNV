using System;

public class Class1
{
	public Class1()
	{

        private double Calculate(SIGN sign, double arg1, double arg2)
    {
        switch (sign)
        {
            case SIGN.PLUS:
                return arg1 + arg2;
            default:
                break;
        }
        return 0d;
    }

}
}
