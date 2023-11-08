namespace Patterns.Structural.Decorator.Bike;

public interface IBike{
    string GetDetails();
    double GetPrice();
}

public class AluminiumBike : IBike{
    public double GetPrice() => 100.0;
    public string GetDetails() => "Aluminium Bike";
}

public class CarbonBike : IBike{
    public double GetPrice() => 1000.0;
    public string GetDetails() => "Carbon";
}


public abstract class BikeAccessories : IBike{
    private readonly IBike _bike;
    public BikeAccessories(IBike bike) {
        _bike = bike;
    }

    public virtual double GetPrice() => _bike.GetPrice();

    public virtual string GetDetails() => _bike.GetDetails();
}

public class SecurityPackage : BikeAccessories{
    public SecurityPackage(IBike bike):base(bike) {
    }
    public override string GetDetails() => base.GetDetails() + " + Security Package";
    public override double GetPrice() => base.GetPrice() + 1;
}
public class SportPackage : BikeAccessories {
    public SportPackage(IBike bike) : base(bike) {
    }
    public override string GetDetails() => base.GetDetails() + " + Sport Package";
    public override double GetPrice() => base.GetPrice() + 10;
}
  


