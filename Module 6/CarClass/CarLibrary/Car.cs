namespace CarLibrary
{
    public class Car
    {
        public int year;
        public string make;
        public string model;
        public double speed;

        public Car(int year, string make, string model)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.speed = 0;
        }

        public void Accelerate()
        {
            speed += 5;
        }

        public void Brake()
        {
            if (speed != 0) speed -= 5;
        }
    }
}
