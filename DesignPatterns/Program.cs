using DesignPatterns.Patterns;

//Singleton
Singleton singleton = Singleton.Instance;
singleton.DoSomething();

//Factory
Creator creator = new ConcreteCreatorA();
Console.WriteLine(creator.SomeOperation());

creator = new ConcreteCreatorB();
Console.WriteLine(creator.SomeOperation());


//Observer
Subject subject = new Subject();

ConcreteObserverA observerA = new ConcreteObserverA();
subject.Attach(observerA);

ConcreteObserverB observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

//Chain of Responsibility
var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
{
    Console.WriteLine($"Client: Who wants a {food}?");

    var result = monkey.Handle(food);

    if (result != null)
    {
        Console.Write($"   {result}");
    }
    else
    {
        Console.WriteLine($"   {food} was left untouched.");
    }
}

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
monkey.Handle("Nut");
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
squirrel.Handle("Nut");

//Strategy
TaxCalculator taxCalculator = new TaxCalculator(new USATaxStrategy());
decimal usaTax = taxCalculator.Calculate(1000);
Console.WriteLine($"Tax in USA for $1000: {usaTax:C}");

taxCalculator.SetStrategy(new CanadaTaxStrategy());
decimal canadaTax = taxCalculator.Calculate(1000);
Console.WriteLine($"Tax in Canada for $1000: {canadaTax:C}");

taxCalculator.SetStrategy(new UKTaxStrategy());
decimal ukTax = taxCalculator.Calculate(1000);
Console.WriteLine($"Tax in UK for $1000: {ukTax:C}");