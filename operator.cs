using System;

namespace SurajSahani{
    
    class Program{
        
        static void Main(string[] s){
            
            // Operators 
            
            int n1=10;
            int n2=20;
            
            // (1) Arithmetic Operator ( +,-,*,/,% )
            
            Console.WriteLine(n1+n2);
            Console.WriteLine(n1-n2);
            Console.WriteLine(n1*n2);
            Console.WriteLine(n1/n2);
            Console.WriteLine(n1%n2);
            
            // (2) Assignment Operator ( +=,-=,*=,/=,%= )
            
            n1+=n2;
            n1-=n2;
            n1*=n2;
            n1/=n2;
            n1%=n2;
            
            Console.WriteLine("Value Of n1 :- "+n1);
            Console.WriteLine("Value Of n2 :- "+n2);
            
            // (3) Conditional / Relational / Comparision ( <,<=,>,>=,==,!= )
            
            Console.WriteLine(n1<n2);
            Console.WriteLine(n1<=n2);
            Console.WriteLine(n1>n2);
            Console.WriteLine(n1>=n2);
            Console.WriteLine(n1==n2);
            Console.WriteLine(n1!=n2);
            
            // (4) Logical Operator 
            
            Console.WriteLine((n1==100) && (n2==200));
            Console.WriteLine((n1==10) && (n2==200));
            Console.WriteLine((n1==10) && (n2==20));
            
            Console.WriteLine((n1==100) || (n2==200));
            Console.WriteLine((n1==10) || (n2==200));
            Console.WriteLine((n1==10) || (n2==20));
            
            Console.WriteLine(!(n1==10));
            Console.WriteLine(!(n1==100));
            
        }
    }
}
