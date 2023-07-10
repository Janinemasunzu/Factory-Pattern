namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calots! Where you Create the vehicle of your choise, and");
            Console.WriteLine("Each vehicle has the different requirements");
            Console.WriteLine("You will have to enter the number of tires you need for your vehicle, to check the requirements.");
            int UserInput;
            var input = int.TryParse(Console.ReadLine(), out UserInput);

            var vehicle = VehicleFactory.GetVehicle(UserInput);
            vehicle.Drive();
        }
    }
}
