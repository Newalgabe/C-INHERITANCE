class Device
{
    private string name;
    private string description;

    public Device(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device: {name}");
    }

    public void DeviceInfo()
    {
        Console.WriteLine($"Device: {name}");
        Console.WriteLine($"Description: {description}");
    }
}

class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Kettle whistles.");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Microwave beeps.");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Car engine roars.");
    }
}

class Ship : Device
{
    public Ship(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Ship horn blows.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kettle kettle = new Kettle("Electric Kettle", "A device to boil water.");
        Microwave microwave = new Microwave("Microwave Oven", "Used for heating and cooking food.");
        Car car = new Car("Sports Car", "A high-performance automobile.");
        Ship ship = new Ship("Cruise Ship", "A large passenger ship for vacations.");

        kettle.Show();
        kettle.Sound();
        kettle.DeviceInfo();

        microwave.Show();
        microwave.Sound();
        microwave.DeviceInfo();

        car.Show();
        car.Sound();
        car.DeviceInfo();

        ship.Show();
        ship.Sound();
        ship.DeviceInfo();
    }
}