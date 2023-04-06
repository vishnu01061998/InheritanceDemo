using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Teacher
    {
        public void GetData()
        {
            Console.WriteLine();
        }
        public void PutData()
        {

        }
    }


    public class ParamanatTeacher : Teacher
    {
        void function1()
        {

        }
    }


    internal class parent
    {

        public parent(int id)  // constructor
        {
            this.Id = id;
        }
        // Data member
        public int Id { get; set; }

        // member function 
        public void function1()
        {

            Console.WriteLine("parent class function 1");
        }
        public void function2()
        {
            Console.WriteLine("parent class function 2");
        }
    }
    internal class Child : parent
    {
      
        // constructor
        public Child() : base(20)
        {
            this.Name = "Vaish";
        }

         // date members
         public string Name { get; set; }


        // member function 
        public void function3()
        {
            Console.WriteLine("Child class function 3");

            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Id=" + Id);

            

        }
        public void function4(int num)  //Formal paramters
        {

            Console.WriteLine("Child class function 4 ");
        }

    }
}