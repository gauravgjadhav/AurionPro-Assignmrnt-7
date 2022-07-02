using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoreProductIncapApp.Model
{
    internal class Product
    {
        private int _id = 0;
        private string _name = null;
        private int _price = 0;
        private double _discountPercentage = 0;
        public double discontPrice = 0;
        public double calculatePrice = 0;

        public void SetId(int id)
        {
            if(id<0)
            {
                throw new ArgumentException("not valid");
                
            }
            else
            {
                this._id = id;
            }
        }
        public void SetName(string name)
        {
            name.ToUpper();
            if (name.Length <1)
            {
                Exception exception = new ArgumentException("Name is Empty");
                
            }
            else
            {
                this._name = name;
            }
        }
        public void SetPrice(int price)
        {
            this._price = price;

        }
        public void SetDiscountPercentage(int percentage)
        {
            if(percentage<=0)
            {

                Exception exception = new ArgumentException("not a valid value");
            }
            else if (percentage >= 100) 
            {

                Exception exception = new ArgumentException("not a valid value");

            }
            else
            {
                this._discountPercentage = percentage;
            }
        }
        public int GetId()
        {
            return this._id;
        }
        public string GetName()
        {
            return this._name;
        }
        public int GetPrice()
        {
            return this._price;
        }
        public double GetDiscountPercentage()
        {
            return this._discountPercentage;

        }
        public double DiscountCalculate()
        {
            _discountPercentage = _discountPercentage / 100;
            discontPrice = _price * _discountPercentage;
            calculatePrice = _price - discontPrice;
            return calculatePrice;

        }
    }
}
