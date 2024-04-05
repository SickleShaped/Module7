namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
        }

    }
    

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }

    class B:A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }

    class C:A
    {
        public override void Display()
        {
                Console.WriteLine("C");
        }
    }

    class D:B
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }

    class E:C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }

}