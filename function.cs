using System;

namespace SurajSahani{
    
    class Program{
        
        // Function without parameter and without return statement
        
        static void hello(){
            Console.WriteLine("Hello");
        }
        
        // Function with parameter and without return statement
        
        static void add(int a,int b){
            Console.WriteLine("Addition of a and b :- "+(a+b));
        }
        
        // Function without parameter and with return statement
        
        static int data(){
            return 5;
        }
        
        // Function with parameter and with return statement
        
        static int sum(int a,int b,int c){
            return a+b+c;
        }
        
        static void Main(string[] s){
            
            hello();
            
            add(5,6);
            
            int a=data();
            Console.WriteLine("Value of a :- "+a);
            
            int result=sum(4,5,6);
            Console.WriteLine("Value of result :- "+result);
            
            
        }
    }
}
