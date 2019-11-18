using System;

namespace LineApplicaation{
    class Line{
        private double length;

        //constructor
        public Line(){
            Console.WriteLine("Object is being created");
        }

        ~Line() {
            Console.WriteLine("Onject is being deleted.");
        }

        public void setLength(double len){
            length = len;
        }

        public double getLength(){
            return length;
        }

        static void Main(string[] args) {
            Line line = new Line();

            line.setLength(6.0);

            Console.WriteLine("Length: {0}", line.getLength());
            Console.ReadKey();
        }
   
    }


}