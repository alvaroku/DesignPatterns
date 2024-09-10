namespace DesignPatterns.Patterns
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal amount);
    }
    public class USATaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.1m; // 10% de impuestos en EE.UU.
        }
    }

    public class CanadaTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.15m; // 15% de impuestos en Canadá
        }
    }

    public class UKTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal amount)
        {
            return amount * 0.2m; // 20% de impuestos en Reino Unido
        }
    }

    public class TaxCalculator
    {
        private ITaxStrategy _taxStrategy;

        // Constructor para definir la estrategia
        public TaxCalculator(ITaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        // Método para cambiar la estrategia en tiempo de ejecución
        public void SetStrategy(ITaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        public decimal Calculate(decimal amount)
        {
            return _taxStrategy.CalculateTax(amount);
        }
    }
}
