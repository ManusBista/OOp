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

            try
            {
                int[] x = { 1, 2, 3, 4, 5 };
                Console.WriteLine(x[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally vetiyo ktaho");
            }

            checkAge(15);
            
        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("access denied Baccha");
            }
            else
            {
                Console.WriteLine("zdtfysb");
            }
        }
    }
}