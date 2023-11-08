namespace Patterns.Creational.Multiton;

using System;
using System.Collections.Generic;

public enum MultitonType
{
    Zero,
    One,
    Two
}

public class Multiton
{
    private static readonly Dictionary<MultitonType, Multiton> instances = new();

    private MultitonType _type;

    private Multiton(MultitonType type)
    {
        _type = type;
    }

    public static Multiton GetInstance(MultitonType type)
    {
        // Lazy init (not thread safe as written)
        // Recommend using Double Check Locking if needing thread safety
        if (!instances.TryGetValue(type, out var instance)){
            instance = new Multiton(type);
           instances.Add(type, instance);
        }

        return instance;
    }

    public override string ToString()
    {
        return _type.ToString();
    }

    
    
    
}