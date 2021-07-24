namespace design_pattern.Interpreter
{
   public class GramerRepresentation
   {
      public const string optionalSpace = " ?";
      public const string qty = "x(?<qty>\\d+)" + optionalSpace;

      public const string produc = "'(?<product>[\\w ]+)'" + optionalSpace;
      public const string source = "from (?<source>\\w+)" + optionalSpace;
      public const string orderCommand = "order " + qty + produc + source;
   }
}