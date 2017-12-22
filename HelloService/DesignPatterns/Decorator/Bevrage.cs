using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Bevrage
    {
        public abstract int Cost();
    }

    public abstract class AddOnDecorator : Bevrage
    {

    }

    public class Caramel : AddOnDecorator
    {
        Bevrage _bevrage;
        public Caramel(Bevrage bevrage)
        {
            _bevrage = bevrage;
        }
        public override int Cost()
        {
            return _bevrage.Cost() + 2;
        }
    }

    public class Soy : AddOnDecorator
    {
        Bevrage _bevrage;
        public Soy(Bevrage bevrage)
        {
            _bevrage = bevrage;
        }
        public override int Cost()
        {
            return _bevrage.Cost() + 1;
        }
    }


    //*********************** Concrete beverage ****************************//

    public class Espresso : Bevrage
    {
        public override int Cost()
        {
            return 10;
        }
    }

    public class MainEntryPoint
    {
        public MainEntryPoint()
        {
            //Bevrage bevrage =
            //    new Soy(new Caramel(new Espresso()));
            //new Caramel(new Espresso());
            //Console.WriteLine(bevrage.Cost());

            A a1 = new A();
            A a2 = new A();

            var equal = a1.GetHashCode() == a2.GetHashCode();
        }
    }

    public class A
    {
        private static int i;
        static A()
        {
            i = 1;
        }

    }
}
