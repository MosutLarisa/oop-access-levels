namespace oop_access_levels.Library
{
    public class Car
    {
        private string manufacturer = "Renault";

        void PrintManufacturer()
        {
            //private field accessible from within the class
            Console.WriteLine(manufacturer);
        }
    }
}