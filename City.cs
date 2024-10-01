
namespace Practice1{

    class City
    {
        private PoliceStation policeStation;
        private List<Taxi> taxis;

        public City()
        {
            policeStation = new PoliceStation();
            taxis = new List<Taxi>();
        }

            public void RegisterPoliceCar(PoliceCar car)
            {
                policeStation.RegisterPoliceCar(car);
            }

            public void RegisterTaxi(Taxi taxi)
            {
                taxis.Add(taxi);
                Console.WriteLine($"Taxi registrado: {taxi.GetPlate()}");
            }

            public void RemoveTaxi(string plate)
            {
                taxis.RemoveAll(t => t.GetPlate() == plate);
            }
        }
        }


    
