using System;

namespace SurajSahani{
    
    class Program{
        
        static void Main(string[] s){
           
           Programming p=new Programming();
           p.id=1;
           p.name="P";
           p.course="C/C++";
           
           Console.WriteLine(p.id+" "+p.name+" "+p.course);
           
           Programming q=new Programming();
           q.setId(2);
           q.setName("Q");
           q.setCourse("ADSP");
           
           Console.WriteLine(q.getId()+" "+q.getName()+" "+q.getCourse());
        }
    }
    
    class Programming{
        
        public int id;
        public string name;
        public string course;
        
        public void setId(int id){
            this.id=id;
        }
        
        public void setName(string name){
            this.name=name;
        }
        
        public void setCourse(string course){
            this.course=course;
        }
        
        public int getId(){
            return this.id;
        }
        
        public string getName(){
            return this.name;
        }
        
        public string getCourse(){
            return this.course;
        }
    }
}
