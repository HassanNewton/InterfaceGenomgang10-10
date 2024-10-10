using System;
namespace ArvGenomgång2
{
	public interface IFordon
	{
		public void Drive();
	}

	public abstract class Car : IFordon
	{
		//Abstrakt metod måste finnas i en Abstrakt klass
		//Abstrakta klasser kan ha både konrketa (vanliga) och abstrakta metoder
		public abstract void Refuel();

		public void Drive()
		{
			Console.WriteLine("Bilen kör...");
		}
	}

	public class ElectricCar : Car
	{
        public override void Refuel()
        {
			Console.WriteLine("Batteriet Laddas");
        }
    }
}

