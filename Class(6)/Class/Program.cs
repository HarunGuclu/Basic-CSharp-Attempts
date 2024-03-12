
using System;

namespace Class
{

    public class cars
    {
        public String carColor;
        public String carModel;
        public int carDoor;
        public cars()
        {
            Console.WriteLine("constructor method is starting");
        }
        public void startengine()
        {
            Console.WriteLine("starting the engine");
        }
        public void closedoor()
        {
            Console.WriteLine("the doors are being closed");
        }
    }
    public class person
    {
        public string Name;
        public string Surname;
        public string id;
        public string job;
    }




    class Program
    {
        static void Main()
        {
            //--------------------------------
            cars car = new cars();
            car.carColor = "Blue";
            car.carModel = "Volvo";
            car.carDoor = 4;
            Console.WriteLine(car.carColor);
            Console.WriteLine(car.carModel);
            Console.WriteLine(car.carDoor);
            car.startengine();
            car.closedoor();    





            person person = new person();
            person.Name = "Aisha ";
            person.Surname = "Elly ";
            person.id = "72554472 ";
            person.job = "Soft Enginner ";
            Console.WriteLine(person.Name + person.Surname + person.id + person.job);
            //----------------------------------




        }



    }
}