#region Template
//using System;

//namespace RefactoringGuru.DesignPatterns.TemplateMethod.Conceptual
//{
   
//    abstract class AbstractClass
//    {
//        public void TemplateMethod()
//        {
//            this.BaseOperation1();
//            this.RequiredOperations1();
//            this.BaseOperation2();
//            this.Hook1();
//            this.RequiredOperation2();
//            this.BaseOperation3();
//            this.Hook2();
//        }

//        protected void BaseOperation1()
//        {
//            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
//        }

//        protected void BaseOperation2()
//        {
//            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
//        }

//        protected void BaseOperation3()
//        {
//            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
//        }

       
//        protected abstract void RequiredOperations1();

//        protected abstract void RequiredOperation2();

     
//        protected virtual void Hook1() { }

//        protected virtual void Hook2() { }
//    }

  
//    class ConcreteClass1 : AbstractClass
//    {
//        protected override void RequiredOperations1()
//        {
//            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
//        }

//        protected override void RequiredOperation2()
//        {
//            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
//        }
//    }

    
//    class ConcreteClass2 : AbstractClass
//    {
//        protected override void RequiredOperations1()
//        {
//            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
//        }

//        protected override void RequiredOperation2()
//        {
//            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
//        }

//        protected override void Hook1()
//        {
//            Console.WriteLine("ConcreteClass2 says: Overridden Hook1");
//        }
//    }

//    class Client
//    {
       
//        public static void ClientCode(AbstractClass abstractClass)
//        {

//            abstractClass.TemplateMethod();
           
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Same client code can work with different subclasses:");

//            Client.ClientCode(new ConcreteClass1());

//            Console.Write("\n");

//            Console.WriteLine("Same client code can work with different subclasses:");
//            Client.ClientCode(new ConcreteClass2());
//        }
//    }
//}
#endregion


#region Visitor
//using System;
//using System.Collections.Generic;

//namespace RefactoringGuru.DesignPatterns.Visitor.Conceptual
//{
//    public interface IComponent
//    {
//        void Accept(IVisitor visitor);
//    }

  
//    public class ConcreteComponentA : IComponent
//    {
      
//        public void Accept(IVisitor visitor)
//        {
//            visitor.VisitConcreteComponentA(this);
//        }

       
//        public string ExclusiveMethodOfConcreteComponentA()
//        {
//            return "A";
//        }
//    }

//    public class ConcreteComponentB : IComponent
//    {
       
//        public void Accept(IVisitor visitor)
//        {
//            visitor.VisitConcreteComponentB(this);
//        }

//        public string SpecialMethodOfConcreteComponentB()
//        {
//            return "B";
//        }
//    }

 
//    public interface IVisitor
//    {
//        void VisitConcreteComponentA(ConcreteComponentA element);

//        void VisitConcreteComponentB(ConcreteComponentB element);
//    }


//    class ConcreteVisitor1 : IVisitor
//    {
//        public void VisitConcreteComponentA(ConcreteComponentA element)
//        {
//            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
//        }

//        public void VisitConcreteComponentB(ConcreteComponentB element)
//        {
//            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
//        }
//    }

//    class ConcreteVisitor2 : IVisitor
//    {
//        public void VisitConcreteComponentA(ConcreteComponentA element)
//        {
//            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2");
//        }

//        public void VisitConcreteComponentB(ConcreteComponentB element)
//        {
//            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
//        }
//    }

//    public class Client
//    {
    
//        public static void ClientCode(List<IComponent> components, IVisitor visitor)
//        {
//            foreach (var component in components)
//            {
//                component.Accept(visitor);
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<IComponent> components = new List<IComponent>
//            {
//                new ConcreteComponentA(),
//                new ConcreteComponentB()
//            };

//            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
//            var visitor1 = new ConcreteVisitor1();
//            Client.ClientCode(components, visitor1);

//            Console.WriteLine();

//            Console.WriteLine("It allows the same client code to work with different types of visitors:");
//            var visitor2 = new ConcreteVisitor2();
//            Client.ClientCode(components, visitor2);
//        }
//    }
//}
#endregion
