namespace Patterns.Creational.Builder.Car;

internal class Vehicle{
    private string _vehicleType;
    private Dictionary<string, string> _parts = new();

   public Vehicle(string vehicleType) {
        this._vehicleType = vehicleType;
    }


    public string this[string key]{
        get{ return _parts[key]; }
        set{ _parts[key] = value; }
    }

   
}