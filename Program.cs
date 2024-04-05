namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
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