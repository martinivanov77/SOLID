﻿using LiskovSubstitutionPrinciple.Abstract;
using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple.Implementatuions
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get ; set; }
        public string Name { get ; set ; }
       

        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        { 
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
}
