namespace Design_Pattern.Factory
{
    public class CarFactory
    {
        protected ICar<string> car;

        public ICar<string> Make(string model)
        {
            if (model == "r") return car = new CarModelR();
            else if (model == "s") return car = new CarModelS();

            return null;
        }
    }
}