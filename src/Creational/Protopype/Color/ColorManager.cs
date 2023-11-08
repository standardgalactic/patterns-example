using System.Collections.Generic;

internal class Colors{
    private Dictionary<string, ColorPrototype> _colors = new();

    public ColorPrototype this[string key]{
        get{ return _colors[key]; }
        set{ _colors.Add(key, value); }
    }
}