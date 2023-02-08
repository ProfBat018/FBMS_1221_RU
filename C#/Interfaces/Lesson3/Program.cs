ITest obj = new A();

obj.foo();

interface ITest
{
    void foo()
    {
        Console.WriteLine("Foo from interface");
    }
}

class A : ITest
{
    public void foo() // неявный override 
    {
        Console.WriteLine("Foo from A");
    }
}




