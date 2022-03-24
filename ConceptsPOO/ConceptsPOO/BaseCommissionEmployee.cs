namespace ConceptsPOO
{
    public class BaseCommissionEmployee : ComissionEmployee
    {
        public decimal Base { get; set; }
        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\tSalary Base: {Base:C2}";

        }
    }
}
