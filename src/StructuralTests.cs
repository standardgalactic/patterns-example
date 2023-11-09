using Patterns.Structural.AdapterPattern;
using Patterns.Structural.Bridge;
using Patterns.Structural.Composite.Menu;
using Patterns.Structural.Decorator.Bike;
using Patterns.Structural.Decorator.Drink;
using Patterns.Structural.Facade.Bank;
using Patterns.Structural.Facade.DvdPlayer;
using Patterns.Structural.FlyWeight.Factory;
using Patterns.Structural.Proxy.Math;

namespace Patterns;

public class StructuralTests
{
    [Fact]
    public void Structural_Adapter()
    {
        var turkey = new WildTurkey();
        var adapter = new TurkeyAdapter(turkey);
        Tester(adapter);

        void Tester(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }

    [Fact]
    public void Structural_Bridge()
    {
        var courier = new Сourier();
        var editor = new Editor();
        var actor1 = new Actor(courier);
        actor1.Work();
        actor1.Rest();
        ;
        var actor2 = new Actor(editor);
        actor2.Work();
        actor2.Rest();
        ;
    }

    [Fact]
    public void Structural_Composite()
    {
        var breakfast = new Menu("Breakfast", "Pancake House");
        var lunch = new Menu("Lunch", "Deli Diner");
        var dinner = new Menu("Dinner", "Dinneroni");

        var dessert = new Menu("Dessert", "Ice Cream");

        var menu = new Menu("All", "McDonalds");

        breakfast.Add(new MenuItem("Waffles", "Butterscotch waffles", 140, false));
        breakfast.Add(new MenuItem("Corn Flakes", "Kellogs", 80, true));

        lunch.Add(new MenuItem("Burger", "Cheese and Onion Burger", 250, true));
        lunch.Add(new MenuItem("Sandwich", "Chicken Sandwich", 280, false));

        dinner.Add(new MenuItem("Pizza", "Cheese and Tomato Pizza", 210, true));
        dinner.Add(new MenuItem("Pasta", "Chicken Pasta", 280, false));

        dessert.Add(new MenuItem("Ice Cream", "Vanilla and Chocolate", 120, true));
        dessert.Add(new MenuItem("Cake", "Choclate Cake Slice", 180, false));

        dinner.Add(dessert);
        menu.Add(breakfast);
        menu.Add(lunch);
        menu.Add(dinner);

        menu.Print();
    }

    [Fact]
    private void Decorator_Drink()
    {
        Beverage beverage = new Espresso();
        Beverage beverage2 = new DarkRoast();
        beverage2 = new MochaCondiment(beverage2);
        beverage2 = new MochaCondiment(beverage2);
        beverage2 = new WhipCondiment(beverage2);
        Beverage beverage3 = new HouseBlend();
        beverage3 = new MochaCondiment(beverage3);
        beverage3 = new WhipCondiment(beverage3);
    }

    [Fact]
    private void Decorator_Bike()
    {
        var basicBike = new AluminiumBike();
        BikeAccessories upgraded = new SportPackage(basicBike);
        upgraded = new SecurityPackage(upgraded);
        Assert.True(100 == basicBike.GetPrice());
        Assert.True(111 == upgraded.GetPrice());
    }

    [Fact]
    private void Facade_Bank()
    {
        Mortgage mortgage = new Mortgage();
        Customer customer = new Customer("Ann McKinsey");
        bool eligible = mortgage.IsEligible(customer, 125000);
    }

    [Fact]
    private void DVD_Player()
    {
        var dimmer = new Dimmer();
        var dvdPlayer = new DvdPlayer();
        var dvd = new Dvd("Gone with the Wind 2 : Electric Bugaloo");
        var homeTheater = new HomeTheatre(dimmer, dvd, dvdPlayer);

        homeTheater.WatchMovie();
        Console.WriteLine();
        homeTheater.Pause();
        Console.WriteLine();
        homeTheater.Resume();
        Console.WriteLine();
        homeTheater.Pause();
    }

    [Fact]
    private void FlightWeight()
    {
        int extrinsicstate = 22;

        FlyweightFactory factory = new FlyweightFactory();


        Flyweight fx = factory.GetFlyweight("X");
        fx.Operation(--extrinsicstate);

        Flyweight fy = factory.GetFlyweight("Y");
        fy.Operation(--extrinsicstate);

        Flyweight fz = factory.GetFlyweight("Z");
        fz.Operation(--extrinsicstate);

        UnsharedConcreteFlyweight fu = new
            UnsharedConcreteFlyweight();

        fu.Operation(--extrinsicstate);
    }

    [Theory]
    [InlineData(1, 2, 4, true)]
    [InlineData(1, 2, 3, false)]
    private void Proxy(int x, int y, int sum, bool expected)
    {
        MathProxy proxy = new MathProxy();
        int r = proxy.Add(x, y);
        Assert.True(expected == (sum == r));
    }
}