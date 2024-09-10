namespace DesignPatterns.Patterns
{
    public abstract class Approver
    {
        protected Approver _nextApprover;

        public void SetNext(Approver nextApprover)
        {
            _nextApprover = nextApprover;
        }

        public abstract void HandleRequest(PurchaseRequest request);
    }
    public class Manager : Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Amount < 1000)
            {
                Console.WriteLine($"Manager approved request# {request.RequestNumber} for {request.Amount:C}.");
            }
            else if (_nextApprover != null)
            {
                _nextApprover.HandleRequest(request);
            }
        }
    }

    public class Director : Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Amount < 5000)
            {
                Console.WriteLine($"Director approved request# {request.RequestNumber} for {request.Amount:C}.");
            }
            else if (_nextApprover != null)
            {
                _nextApprover.HandleRequest(request);
            }
        }
    }

    public class CEO : Approver
    {
        public override void HandleRequest(PurchaseRequest request)
        {
            if (request.Amount >= 5000)
            {
                Console.WriteLine($"CEO approved request# {request.RequestNumber} for {request.Amount:C}.");
            }
            else if (_nextApprover != null)
            {
                _nextApprover.HandleRequest(request);
            }
        }
    }
    public class PurchaseRequest
    {
        public int RequestNumber { get; }
        public double Amount { get; }

        public PurchaseRequest(int requestNumber, double amount)
        {
            RequestNumber = requestNumber;
            Amount = amount;
        }
    }
}
