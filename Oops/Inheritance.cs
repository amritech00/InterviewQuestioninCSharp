namespace Oops
{
    public class BaseClass
    {
        public BaseClass() { }
        public BaseClass(string name) 
        {
            Console.WriteLine("In BaseClass ctor" + name);
        }
        public virtual void Show()
        {
            Console.WriteLine("Show method from Base Class");
        }
        public void Hide()
        {
            Console.WriteLine("Hide method");
        }
    }

    public class ChildClass : BaseClass
    {
        public ChildClass() { }
        public ChildClass(string name)
        {
            Console.WriteLine("In child class ctor" + name);
        }
        public sealed override void Show()
        {
            Console.WriteLine("Show method from Child Class");
        }

        public new void Hide()
        {
            Console.WriteLine("hide method in child");
        }
    }

    public class ChildClass2 : ChildClass
    {
        public ChildClass2()
        {
            
        }
        public ChildClass2(string name)
        {
            Console.WriteLine("In childclass2" + name);
        }
        public new void Show()
        {
            Console.WriteLine("Show method from Child Class2");
        }
    }
}
