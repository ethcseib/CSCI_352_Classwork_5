/*Ethan Seiber
 * Date: 2/7/19
 * Assignment: Classwork 5
 * File: Adapter Pattern
*/
using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main()
        {
            Bear GrizzlyBear = new Grizzly();
            ToyBear MrTeddy = new TeddyBear();
            ToyBear ANewBear = new BearAdapter(GrizzlyBear);

            GrizzlyBear.maul();
            GrizzlyBear.hibernate();

            MrTeddy.hug();

            ANewBear.hug();//adapted Bear class

            Console.ReadKey();
        }
    }
}

interface ToyBear//Target
{
    void hug();
}

interface Bear//Adaptee
{
    void maul();
    void hibernate();
}

class Grizzly : Bear
{
    public void maul()
    {
        Console.WriteLine("The bear mauls\n");
    }
    
    public void hibernate()
    {
        Console.WriteLine("The bear hibernates\n");
    }
}

class TeddyBear : ToyBear
{
    public void hug()
    {
        Console.WriteLine("The teddy bear hugs\n");
    }
}

class BearAdapter : ToyBear//Adapter class
{
    Bear BabyBear;

    public BearAdapter(Bear BigBear)
    {
        BabyBear = BigBear;
    }
    public void hug()
    {
        BabyBear.maul();
    }
}