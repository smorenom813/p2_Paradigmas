

namespace Practice2
{
    class PoliceCar : Plate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private bool isChasing;
        private string speedingVehiclePlate;
        private PoliceStation policeStation;


        public PoliceCar(string plate, PoliceStation station) : base(plate, typeOfVehicle)
        {
            isPatrolling = false;
            speedRadar = null;
            isChasing = false;
            speedingVehiclePlate = "";
            policeStation = station;
        }

        public void UseRadar(Plate vehicle)
        {
            if (isPatrolling)

            {
                if (speedRadar != null)
                {
                    float VehicleSpeed = speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                    if (VehicleSpeed > speedRadar.GetLegalSpeed())
                    {
                        isChasing = true;
                        speedingVehiclePlate = vehicle.GetPlate();
                        policeStation.ActivateAlert(speedingVehiclePlate, this);
                    }
                }
                else
                {
                    Console.WriteLine(WriteMessage("No radar installed."));
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
        public void SetRadar()
        {
            speedRadar = new SpeedRadar();
        }

        public void PrintRadarHistory()
        {   if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("No radar installed."));

            }
        }

        public void ReceiveAlert(string VehiclePlate)
        {
            if (isPatrolling)
            {
                isChasing = true;
                speedingVehiclePlate = VehiclePlate;
                Console.WriteLine(WriteMessage($"Recieved Alert, start chasing {VehiclePlate}"));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }


        }
    }
}