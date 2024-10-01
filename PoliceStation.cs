
namespace Practice1
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
            
        }

        public void ActivateAlert(string speedingVehiclePlate, PoliceCar triggeringCar)
        { 

           
            foreach (var car in policeCars)
            {
                if (car != triggeringCar)
                {
                    car.ReceiveAlert(speedingVehiclePlate);
                }
            }
        }
    }


}


