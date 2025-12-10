using System;

namespace Overriding
{
    class Armorsuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : Armorsuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : Armorsuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            Armorsuite armorsuite = new Armorsuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            Armorsuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMaching...");
            Armorsuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}