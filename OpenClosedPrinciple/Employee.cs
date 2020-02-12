using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        //This is an abstract method, which works in a similar way as an interface's method and it's not implemented in the base class. 
        //The implementation happens in derrived classes
        public abstract decimal CalculateBonus(decimal salary);
      
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }
    }
}
