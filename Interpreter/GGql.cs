using System.Text.RegularExpressions;

namespace design_pattern.Interpreter
{
   public class GGql
   {
      private readonly string _command = GramerRepresentation.orderCommand;
      public int qty { get; set; }
      public string product { get; set; }
      public string source { get; set; }
      public GGql(int qty, string product, string source)
      {
         this.qty = qty;
         this.product = product;
         this.source = source;
      }
      public static GGql Interpreter(string str)
      {
         Regex _regex = new Regex(GramerRepresentation.orderCommand);
         var matchs = _regex.Match(str);

         if (!matchs.Success)
            return null;

         var qty = int.Parse(matchs.Groups["qty"].Value);
         var product = matchs.Groups["product"].Value;
         var source = matchs.Groups["source"].Value;

         return new GGql(qty, product, source);
      }
   }
}