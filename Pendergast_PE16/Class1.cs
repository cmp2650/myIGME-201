using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE16
{
    public interface IMood
    {
        string Mood { get; }
    }
    public class Customer : IMood
    {
        public string name;
        private string creditCardNumber;
        public string CreditCardNumber
        {
            set
            {
                this.creditCardNumber = value;
            }
        }
        public string Mood { get; }
    }

    public class Waiter : IMood
    {
        public string name;
        public string Mood { get; }
        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string brand;
        public string size;

        public Customer customer;

        public HotDrink()
        {
            this.instant = false;
            this.milk = false;
            this.sugar = 0;
            this.size = "medium";

            this.customer = new Customer();
        }

        public HotDrink(string brand)
        {
            // Folgers is instant coffee
            if (brand == "Folgers")
            {
                this.instant = true;
            }

            this.brand = brand;

            this.customer = new Customer();
        }

        public virtual void AddSugar(byte amount)
        {
            sugar += amount;
        }

        public abstract void Steam();
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public CupOfCoffee()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {
            if (brand == "Folgers")
            {
                this.beanType = "rancid";
            }
        }

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }
    }
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;
        public CupOfTea()
        {

        }
        public CupOfTea(bool customerIsWealthy)
        {
            if (true)
            {
                Console.WriteLine("please give me some money i work as a barista for minimum wage i beg of you please tip me");
            }
        }
        public override void Steam()
        {
            
        }
        public void TakeOrder()
        {

        }
    }

    public class CupOfCocoa: HotDrink, ITakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        private string Source
        {
            set { source = value; }
        }
        public override void Steam()
        {
            Console.WriteLine("Steamy");
        }
        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }
        public void TakeOrder()
        {

        }
        public CupOfCocoa() : this(false)
        {

        }
        public CupOfCocoa(bool marshmallows):base("Expensive Organic Brand")
        {

        }
    }
}
