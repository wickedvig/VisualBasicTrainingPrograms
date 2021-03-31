namespace TrainingExample1
{
    class Program
    {

        static void Main(string[] args)
        {
            Car[] car = new Car[3];
            car[0] = new Car();
            car[1] = new Car();
            car[2] = new Car();

            car[0].Display();
            car[1].Display();
            car[2].Display();

            car[0].DisplayCar();
            car[1].DisplayCar();
            car[2].DisplayCar();
        }
    }
}
