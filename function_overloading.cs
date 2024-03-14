using System;

namespace SurajSahani{
    
    class Program{
        
        static void add(int a,int b){
            Console.WriteLine("Addition of a and b :- "+(a+b));
        }
        
        static void add(int a,int b,int c){
            Console.WriteLine("Addition of a,b and c :- "+(a+b+c));
        }
        
        static void add(int a,int b,int c,int d){
            Console.WriteLine("Addition of a,b,c and d :- "+(a+b+c+d));
        }
        
        static void Main(string[] s){
            
            add(4,5);
            
            add(4,5,6);
            
            add(4,5,6,7);
            
            
        }
    }
}
