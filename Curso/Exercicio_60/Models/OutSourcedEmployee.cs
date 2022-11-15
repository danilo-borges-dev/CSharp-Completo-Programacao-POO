namespace Exercicio_60.Models
{
    internal class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; } = new double();

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;    
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AdditionalCharge + AdditionalCharge * 0.1);
        }
    }
}
