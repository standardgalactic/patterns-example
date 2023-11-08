namespace Patterns.Creational.Builder.Car;

internal class Factory{
    public Vehicle Construct(VehicleBuilder vehicleBuilder) {
        vehicleBuilder.BuildFrame();
        vehicleBuilder.BuildEngine();
        vehicleBuilder.BuildWheels();
        vehicleBuilder.BuildDoors();
        return vehicleBuilder.Vehicle;
    }
}