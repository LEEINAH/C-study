using System;

class Base
{
    public virtual void SealMe()
    {

    }
}

class Derived : Base 11 {
    public sealed override void SealMe()
    {
        
    }
}

class WantToOverride : Derived
{
    public override void SealMe()
    {

    }
}

class MainApp
{
    static void Main(string[] args)
    {

    }
}