﻿namespace Practice2
{
    abstract class Vehicle : IMessageWritter
    {
        private string typeOfVehicle;
        private float speed;

        public Vehicle(string typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
        }



        public string GetTypeOfVehicle()
        {
            return typeOfVehicle;
        }




        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }

    }
}
