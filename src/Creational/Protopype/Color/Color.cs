using System;

internal class Color : ColorPrototype{
    private int _red;
    private int _green;
    private int _blue;

    // Constructor

    public Color(int red, int green, int blue) {
        _red = red;
        _green = green;
        _blue = blue;
    }


    public override ColorPrototype Clone() {
     
        return this.MemberwiseClone() as ColorPrototype;
    }
}