using System;

namespace LSP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can replace an object of type fruit with object of type Orange which is a derrived type/ subtype of fruit, without causing the application to misbehave
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());

            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
