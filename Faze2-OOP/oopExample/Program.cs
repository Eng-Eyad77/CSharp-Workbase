using MyFirstProgram;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "F150", 2026, 140, 4);
            Car car2 = new Car("MG", "750E", 2014, 200, 4);
            Motorcycle motorcycle1 = new Motorcycle("BMW", "1000CC", 2020, 300, false);
            Motorcycle motorcycle2 = new Motorcycle("Suzuki", "650CC", 2022, 190, true);
            Truck truck1 = new Truck("mercedes", "Big truck", 2010, 100, 1000);

            Vehicle[] vehicles = { car1, car2, motorcycle1, motorcycle2, truck1 };
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Car car)
                {
                    vehicle.Start();
                    System.Console.WriteLine(car.Brand + " " + car.Model + " " + car.Year + " " + car.Speed + " " + car.NumberOfDoors);
                    //  car.Move(); another way to do the interface i didn`t remove it so i can see the difference later 
                }
                else if (vehicle is Motorcycle motorcycle)
                {
                    vehicle.Start();
                    System.Console.WriteLine(motorcycle.Brand + " " + motorcycle.Model + " " + motorcycle.Year + " " + motorcycle.Speed + " " + motorcycle.IsHaveSidecar);
                    // motorcycle.Move(); another way to do the interface i didn`t remove it so i can see the difference later
                }
                else if (vehicle is Truck truck)
                {
                    vehicle.Start();
                    System.Console.WriteLine(truck.Brand + " " + truck.Model + " " + truck.Year + " " + truck.Speed + " " + truck.Capacity);
                    // truck.Move(); another way to do the interface i didn`t remove it so i can see the difference later
                }
                else
                {
                    System.Console.WriteLine("There is No Vehicle with this Name.");
                    continue;
                }




            }


            //this is the beast way to implement the interface
            IMovable[] movables = { car1, car2, motorcycle1, motorcycle2, truck1 };
            foreach (IMovable movable in movables)
            {
                movable.Move();
            }
            Console.ReadKey();
        }
    }

    interface IMovable
    {
        void Move();
    }
    class Vehicle
    {
        // the ? after the  string variables is to remove the non-null mark -  means the string is nullable and can have a null value.
        private string? brand;


        public string? Brand
        {
            get { return brand; }
            set { brand = value; }
        }


        private string? model;
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 300)
                {
                    speed = 300;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public Vehicle(string coBrand, string coModel, int coYear, int coSpeed) // co is shortcut for Constructor to identify this is parameter for the Constructor
        {
            this.Brand = coBrand;
            this.Model = coModel;
            this.Year = coYear;
            this.Speed = coSpeed;
            // all the variables this. is public Properties
        }

        public virtual void Start()
        {
            System.Console.WriteLine("Vehicle is Starting");
        }


    }


}
class Car : Vehicle, IMovable
{
    int numberOfDoors;
    public int NumberOfDoors
    {
        get { return numberOfDoors; }
        set { numberOfDoors = value; }
    }
    public Car(string coBrand, string coModel, int coYear, int coSpeed, int coNumberOfDoors) : base(coBrand, coModel, coYear, coSpeed)
    {
        this.NumberOfDoors = coNumberOfDoors;
    }

    public override void Start()
    {
        System.Console.WriteLine(" The Car starting the engine!");
    }

    public void Move()
    {
        System.Console.WriteLine("Car is moving forward");
    }
}

class Motorcycle : Vehicle, IMovable
{
    bool isHaveSidecar;
    public bool IsHaveSidecar
    {
        get { return isHaveSidecar; }
        set { isHaveSidecar = value; }
    }

    public Motorcycle(string coBrand, string coModel, int coYear, int coSpeed, bool coIsHaveSidecar) : base(coBrand, coModel, coYear, coSpeed)
    {
        this.IsHaveSidecar = coIsHaveSidecar;
    }

    public override void Start()
    {
        System.Console.WriteLine(" The Motorcycle starting the engine!");
    }
    public void Move()
    {
        System.Console.WriteLine("Motorcycle is moving forward");
    }

}
class Truck : Vehicle, IMovable
{
    int capacity;
    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public Truck(string coBrand, string coModel, int coYear, int coSpeed, int coCapacity) : base(coBrand, coModel, coYear, coSpeed)
    {
        this.Capacity = coCapacity;
    }

    public override void Start()
    {
        System.Console.WriteLine(" The Truck starting the engine!");
    }

    public void Move()
    {
        System.Console.WriteLine("Truck is moving forward");
    }
}

