using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Teacher teacher= new Teacher();
            teacher.GetData();
            teacher.PutData();
            

                

            Child C = new Child();

            int result = 10;

            C.function4(result);  // Actual parameters

            parent p = new parent(10);


            Child c1;
            parent p1;
            


            //c1= p; // invalid
              p1 = C;  // Valid

            // p1 is the variable of parent class but its the refernce of child class

            // p1.function3();




            //Child C;   //This is Variable

            //C = new Child();//Instance of the class


            //Child C2 = new Child();  //instace of the class

            //Child C3;   //variable of the class
            //C3 = C2;   //Reference of the class
            
        }
    }
}
