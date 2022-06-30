namespace OOp
{
      class Program
    {
        static void Main(string[] args)
        {
            Car Nissan = new Car("Skyline", "Mat-black", 1996, true);
            Nissan.AboutCar();
            Nissan.Exhust();
            ArkoCar Toyota = new ArkoCar("Supra","orange",2000,true);
            Toyota.AboutCar();
            Toyota.Exhust();

            //properties(get:set:)
            Person person = new Person();
            person.Name = "Manus";
            Console.WriteLine(person.Name);
        }
    }
}