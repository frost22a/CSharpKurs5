namespace _2_Dependencies
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public static Car Add(string Name)
        {
            return new Car(Name);
        }
    }
}