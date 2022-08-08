using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolermorfismoExFx2.Entities
{
    /*Classe Principal*/
    internal class Product
    {
        //atributos
        private string _name;
        private double _price;

        //Construtor
        public Product() 
        { 
        }

        public Product(string name, double price) 
        {
            _name = name;
            _price = price;
        }

        //get e set
        public string GetName() 
        {

            return _name;

        }

        public void SetName(string name) 
        {

            _name = name;

        }

        public double GetPrice() {

            return _price;

        }

        public void SetPrice(double price) {

            _price = price;
        
        }

        //methods

        /*method sobrescrito*/
        public virtual string PriceTag() {

            return "Name Product: "
                + GetName() 
                + " $" 
                + GetPrice().ToString();

        }
    }
}
