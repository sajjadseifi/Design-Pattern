namespace Design_Pattern.Interpreter.RealWord
{
    public class ThousandExpression : Expression
    {
        public override string One() => "M";
        public override string Four() => " ";
        public override string Five() => " ";
        public override string Nine() => " ";
        public override int Multiplier() => 1000;
    }
    public class HundredExpression : Expression
    {
        public override string One() => "C";
        public override string Four() => "CD";
        public override string Five() => "D";
        public override string Nine() => "CM";
        public override int Multiplier() => 100;
    }
    public class TenExpression : Expression
    {
        public override string One() => "X";
        public override string Four() => "XL";
        public override string Five() => "L";
        public override string Nine() => "XC";
        public override int Multiplier() => 10;
    }
    public class OneExpression : Expression
    {
        public override string One() => "I";
        public override string Four() => "IV";
        public override string Five() => "V";
        public override string Nine() => "IX";
        public override int Multiplier() => 1;
    }
}