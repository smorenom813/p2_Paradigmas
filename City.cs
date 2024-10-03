
namespace Practice2{

    class City : IMessageWritter
    {
        private PoliceStation policeStation;
        private List<Taxi> taxis;

        public City()
        {
            policeStation = new PoliceStation();
            taxis = new List<Taxi>();
        }



        public void RegisterTaxi(Taxi taxi)
        {
            taxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} registered"));

        }

        public void RemoveTaxi(string plate)
        {
            taxis.RemoveAll(t => t.GetPlate() == plate);
            Console.WriteLine(WriteMessage($"Taxi with plate {plate} removed"));
        }

        public virtual string WriteMessage(string message)
        {
            return $"City :{message}";
        }
    }
        }


    
