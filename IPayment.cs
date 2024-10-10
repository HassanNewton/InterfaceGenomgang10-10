using System;
namespace ArvGenomgång2
{
	public interface IPayment
	{
		void ProcessPayment();
	}

	public class CreditCardPayment : IPayment
	{
		public void ProcessPayment()
		{
			Console.WriteLine("Credit card is processing");
		}
	}

    public class SwishPayment : IPayment
    {
        public void ProcessPayment()
        {
			Console.WriteLine("Swishen skickas");
        }
    }

}

