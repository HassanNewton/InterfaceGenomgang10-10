using System;
namespace ArvGenomgång2
{
	public interface IAnimal
	{
		public void MakeSound();
	}

	public interface IPet
	{
		public void Play();
	}

	public class Dog : IAnimal, IPet
	{
		 public void MakeSound()
		{
			Console.WriteLine("Woof Woof");
		}

		public void Play()
		{
			Console.WriteLine("The dog is playing");
		}
	}
}

