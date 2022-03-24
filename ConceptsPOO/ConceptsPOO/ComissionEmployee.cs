namespace ConceptsPOO
{
    public class ComissionEmployee : Employee
    {
        public float ComissionPercent { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ComissionPercent;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tPercent for sell: {ComissionPercent:P2}" +
                $"\n\tSales: {Sales:C2}" +
                $"\n\tValue to pay: {GetValueToPay():C2}";
        }
    }
}
