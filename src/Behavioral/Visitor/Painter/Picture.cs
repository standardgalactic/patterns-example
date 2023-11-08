namespace Patterns.Behavioral.Visitor.Painting;

public class Picture: Scetch {
    public Scetch[] _scetches { get; }
    

    public Picture(params Scetch[] scetches) {
        _scetches = scetches;
    }
    public override void Paint() {
        foreach (Scetch scetch in _scetches){
            scetch.Paint();
        }
    }
    public override decimal Price {
        get{
            decimal price = default;
            foreach (Scetch scetch in _scetches){
                price += scetch.Price;
            }
            return price;
        }
    }
    
    
    
}



public class Scetch1 : Scetch{
    public override void Paint() {
        
    }

    public override decimal Price => 10;

}


public class Scetch2 : Scetch{
    public override void Paint() {
    }

    public override decimal Price => 30;

}