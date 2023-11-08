using System.Collections;

namespace Patterns.Structural.FlyWeight.Factory;

internal class FlyweightFactory
    {
        private Hashtable flyweights = new ();

      public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)=> (Flyweight)flyweights[key];
        
    }
