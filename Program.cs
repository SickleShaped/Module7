namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Display();
        }

    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }

        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Нет");
                }
                else
                {
                    Counter=value;
                }
            }
        }
    }

}