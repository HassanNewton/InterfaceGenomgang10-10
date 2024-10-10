namespace ArvGenomgång2;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Välj betalmetod: 1: Credit kort \n 2: Swish");
        int val = Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1:
                CreditCardPayment card = new CreditCardPayment();
                card.ProcessPayment();
                break;
            case 2:
                SwishPayment swish = new SwishPayment();
                swish.ProcessPayment();
                break;
            default:
                Console.WriteLine("Välj mellan 1 och 2 tack!");
                break;
        }
        
    }
}

