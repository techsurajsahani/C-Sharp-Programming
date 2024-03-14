using System;

namespace SurajSahani{
    
    class Program{
        
        static void Main(string[] s){
           
           Programming q=new Programming();
           q.setId(2);
           q.setName("Q");
           q.setCourse("ADSP");
           
           Console.WriteLine(q.getId()+" "+q.getName()+" "+q.getCourse());
        }
    }
    
    class Programming{
        
        private int id;
        private string name;
        private string course;
        
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
