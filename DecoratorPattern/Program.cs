using DecoratorPattern;

System.Console.WriteLine("- Decorator Pattern\n\n");

IComponent oComponent = new Component();

Utility.Display("1. Basic component: ", oComponent);
Utility.Display("2. A-decorated : ", new DecoratorA(oComponent));
Utility.Display("3. B-decorated : ", new DecoratorB(oComponent));
Utility.Display("4. B-A-decorated : ", new DecoratorB(new DecoratorA(oComponent)));

// Explicit DecoratorB
DecoratorB b = new DecoratorB(new Component());
Utility.Display("5. A-B-decorated : ", new DecoratorA(b));