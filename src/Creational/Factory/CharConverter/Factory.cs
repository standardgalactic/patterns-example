namespace Patterns.Creational.Factory.CharConverter;
internal abstract class Factory {
     public Model Make(char c)
        {
            var model= Create(c);
            char v= model.Get();
            model.Parse(v);
      
            return model;
        }
        protected abstract Model Create(char c);
    }