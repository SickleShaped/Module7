namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    class Engine { }
    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    class CarPart { }

    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }

}