using System;

namespace TrainingExample1
{
    class Car
    {

        public string model;
        public string color;
        public int vehicleno;
        private int engineno;


        private int EngineNo { get { return engineno; } set { engineno = value; } }


        public void GetFromInput()
        {
            Console.Write("Enter the model of car: ");
            model = Console.ReadLine();
            Console.Write("Enter the color of car: ");
            color = Console.ReadLine();
            Console.Write("Enter the vehicleno of car: ");
            vehicleno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the engineno of car: ");
            engineno = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            GetFromInput();
        }
        public void DisplayCar()
        {
            Console.WriteLine("Car Model:{0}, Car Color:{1}, VehicleNum:{2}, EngineNum:{3}", model, color, vehicleno, engineno);
        }

    }
}
