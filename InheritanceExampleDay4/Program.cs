using System;

class Class1
{

    public virtual void M()
    {
        Console.WriteLine("class1: M");
    }
    public virtual void N()
    {
        Console.WriteLine("class1: N");
    }


}
class Class2 : Class1
{



    public new void M()
    {
        Console.WriteLine("class2: M");
    }
    public override void N()
    {
        base.N();
        Console.WriteLine("class2: N");
    }

}



class MainClass
{
    static void Main()
    {
        Class1 c1 = new Class2();
        c1.M();
        c1.N();


    }
}