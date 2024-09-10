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
Approver manager = new Manager();
Approver director = new Director();
Approver ceo = new CEO();

manager.SetNext(director);
director.SetNext(ceo);

var request1 = new PurchaseRequest(1, 500);
var request2 = new PurchaseRequest(2, 2000);
var request3 = new PurchaseRequest(3, 10000);

manager.HandleRequest(request1);
manager.HandleRequest(request2);
manager.HandleRequest(request3);

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