using System;

namespace SurajSahani{
    
    public class Program{
        
        public static void Main(string[] s){
          
          A a=new A();
          B b=new B();
          
          a.display();
          b.display();
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

}
