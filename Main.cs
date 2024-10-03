namespace Practice2
{
    internal class Program
    {

        static void Main()
        {

            City city = new City();
            PoliceStation policeStation = new PoliceStation();
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);


            PoliceCar policeCar1 = new PoliceCar("0001 CNP", policeStation);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", policeStation);
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", policeStation);

            policeCar1.SetRadar();
            policeCar2.SetRadar();

            policeStation.RegisterPoliceCar(policeCar1);
            policeStation.RegisterPoliceCar(policeCar2);
            policeStation.RegisterPoliceCar(policeCar3);



            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            policeCar3.StartPatrolling();
            policeCar3.UseRadar(taxi2);

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            city.RemoveTaxi(taxi2.GetPlate());


            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();


            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();




            


        }
    }
}
    

