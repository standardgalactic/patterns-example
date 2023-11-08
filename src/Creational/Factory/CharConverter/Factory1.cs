namespace Patterns.Creational.Factory.CharConverter;

internal class Factory1:Factory {

    protected  override Model Create(char c) {
        char nc =  (char) ( Convert.ToInt32(c) + 3);
        return new Model(nc );
    }
}