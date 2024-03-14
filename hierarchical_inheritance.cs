using System;

namespace SurajSahani{
    
    public class Program{
        
        public static void Main(string[] s){
          
          A a=new A();
          B b=new B();
          C c=new C();
        
          a.display();
          b.display();
          c.display();

        }
    }
    
    class A{
       public void display(){
           Console.WriteLine("Class A");
       } 
    }
    
    class B : A{
       public void display(){
           Console.WriteLine("Class B");
       } 
    }
    
    class C : A{
       public void display(){
           Console.WriteLine("Class C");
       } 
    }

}
