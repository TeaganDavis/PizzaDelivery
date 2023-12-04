using BlazorPizza.Components.Pages;

namespace BlazorPizza
{
    public class Pizza
    {
        public Topping PizzaTopping { get; set; }
        public Crust PizzaCrust { get; set; }
        public PizzaCal PizzaCalc { get; set; }
        public Pizza()
        {
            
            PizzaTopping = new Topping();
            PizzaCrust = new Crust();
            PizzaCalc = new PizzaCal();

        }
        public double GetFinalPrice()
        {

            return PizzaTopping.ToppingPrice();
        }
        public double GetCrustPrice()
        {
            return PizzaCrust.CrustPrice();
        }
        public double CurrentPrice()
        {
            double cTotal= GetFinalPrice() + GetCrustPrice();
            return cTotal;
        }
        public double GetTip()
        {
            return (CurrentPrice() + 2.00) * PizzaCalc.MTip();

        }
        public double EndTotal()
        {
            double priceWFee = CurrentPrice() + 2.00;
            double endTotal = priceWFee+(priceWFee * PizzaCalc.MTip());
            return endTotal;
        }
    }
    public class Crust { 
        public bool Thin { get; set; }
        public bool Pan { get; set; }
        public bool Hand { get; set; }
        public double CrustPrice()
        {
            double cTotal = 0;
            if (Thin)
            {
                cTotal += 5.99;
                Pan = false;
                Hand = false;
            }
            if (Pan)
            {
                cTotal += 7.99;
                Thin = false;
                Hand = false;
            }
            if (Hand)
            {
                cTotal += 6.99;
                Thin = false;
                Pan = false;
            }

            return cTotal;
        }
    }


    public class PizzaCal
    {
        public bool twelve { get; set; }
        public bool fifteen { get; set; }
        public bool eighteen { get; set; }
        public double tip { get; set; }
        
        public double MTip()
        {
            double tip = 0;
            if (twelve)
            {
                tip = .12;
            }else
                if (fifteen)
            {
                tip = .15;
                }else
                    if(eighteen){
                tip = .18;
            }
            return tip;
        }
        
       
    }

    public class Topping
    {
        public bool Pepperoni { get; set; }
        public bool ExtraCheese { get; set; }
        public bool Ham { get; set; }
        public bool Chicken { get; set; }
        public double ToppingPrice()
        {
            double runningTotal = 0;
            if (Pepperoni)
            {
                runningTotal += 1.50;
            }
            if (ExtraCheese)
            {
                runningTotal += 2.00 ;
            }
            if (Ham)
            {
                runningTotal += 1.79;
            }
            if (Chicken)
            {
                runningTotal += 3;
            }
            return runningTotal;

        }
    }
}
