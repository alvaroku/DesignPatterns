namespace DesignPatterns.Patterns
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return "Creator: The same creator's code has just worked with " + product.Operation();
        }
    }

    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public interface IProduct
    {
        string Operation();
    }

    public class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductA}";
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProductB}";
        }
    }
}
