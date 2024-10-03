
namespace Practice2
{
    class PoliceStation
    {


        private List<PoliceCar> policeCars;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
        }

        public void RegisterPoliceCar(PoliceCar car)
        {
            policeCars.Add(car);
            Console.WriteLine(WriteMessage($"Police Car with plate {car.GetPlate()} registered in the police station"));
            
        }

        public void ActivateAlert(string speedingVehiclePlate, PoliceCar triggeringCar)
        {

            Console.WriteLine(WriteMessage($"Alert received from police car with plate : {triggeringCar.GetPlate()}, starting operation to chase {speedingVehiclePlate}"));
            foreach (var car in policeCars)
            {
                if (car != triggeringCar)
                {
                    car.ReceiveAlert(speedingVehiclePlate);
                }
            }
        }
        public virtual string WriteMessage(string message)
        {
            return $"Police Station says:{message}";
        }
    }


}


