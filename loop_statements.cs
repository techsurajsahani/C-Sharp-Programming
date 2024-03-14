using System;

namespace SurajSahani{
    
    class Program{
        
        static void Main(string[] s){
            
            // Loop Statements 
            
            // For Loop 
            
            Console.WriteLine("***** For Loop *****");
            
            for(int i=1;i<11;i++){
                Console.WriteLine("2 * "+i+" = "+(2*i));
            }
            
            // While Loop 
            
            Console.WriteLine("***** While Loop *****");
            
            int j=1;
            while(j<11){
                Console.WriteLine("2 * "+j+" = "+(2*j));
                j++;
            }
            
            // Do While Loop 
            
            Console.WriteLine("***** Do While Loop *****");
            
            int k=1;
            do{
                Console.WriteLine("2 * "+k+" = "+(2*k));
                k++;
            }while(k<11);
        }
    }
}
