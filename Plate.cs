namespace Practice2
{
    class Plate: Vehicle

    {
        private string plate;
        private string typeOfVehicle;

        public Plate(string plate, string typeOfVehicle): base(typeOfVehicle)
        {
            this.plate = plate;
        }



        public string GetPlate()
        {
            return plate;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {plate}";
        }


    }






}

