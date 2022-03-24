namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }
        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tWorked Hours: {Hours:N2} hours" +
                $"\n\tHour Price: {HourValue:C2}" +
                $"\n\tValue to Pay: {GetValueToPay():C2}";
        }
    }
}
