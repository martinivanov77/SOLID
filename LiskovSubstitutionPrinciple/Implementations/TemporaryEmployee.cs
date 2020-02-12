using LiskovSubstitutionPrinciple.Abstract;

namespace LiskovSubstitutionPrinciple.Implementatuions
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

        public override decimal GetMinimumSalary()
        {
            return 5200;
        }
    }
}