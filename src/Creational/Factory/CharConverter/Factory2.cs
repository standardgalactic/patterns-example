namespace Patterns.Creational.Factory.CharConverter;

internal class Factory2:Factory {
    protected  override Model Create(char c) {
        char nc =  (char) ( Convert.ToInt32(c) + 10);
        return new Model(nc );
    }
}