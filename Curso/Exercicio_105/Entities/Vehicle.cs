namespace Exercicio_105.Entities
{
    internal class Vehicle
    {
        public string Model { get; private set; }
        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
