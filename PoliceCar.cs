using Practica1;

namespace Practice1
{
    class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        private bool isChasing;
        private string speedingVehiclePlate;
        private PoliceStation policeStation;


        public PoliceCar(string plate, PoliceStation station) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = new SpeedRadar();
            isChasing = false;
            speedingVehiclePlate = "";
            policeStation = station;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                float VehicleSpeed = speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                if (VehicleSpeed > speedRadar.GetLegalSpeed()) {
                    isChasing = true;
                    speedingVehiclePlate = vehicle.GetPlate();
                    policeStation.ActivateAlert(speedingVehiclePlate, this);
                }

            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }

        public void ReceiveAlert(string VehiclePlate)
        {
            isChasing = true;
            speedingVehiclePlate = VehiclePlate;

        }
    }
}