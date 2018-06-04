
namespace ConsoleApp
{
    public abstract class Ship
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public Ship()
        {
            Id = 0;
        }
    }

    public class Transport : Ship
    {
        public int Capacity { get; set; }
        public Transport()
        {

        }

    }

    public class Carrier:Ship
    {

        
    }



}