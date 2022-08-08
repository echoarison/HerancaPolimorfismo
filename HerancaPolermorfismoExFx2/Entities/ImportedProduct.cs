using System;
using System.Globalization;

namespace HerancaPolermorfismoExFx2.Entities
{
    /**
     * 
     * Vai herdar da Class Product
     * os atributos e methods
     * 
     * */
    internal class ImportedProduct : Product
    {
        //atributos da subClass
        private double _customFree;

        //Construtor
        public ImportedProduct() 
        {

        }

        //aqui o construtor esta herdadando a base da Class Product
        public ImportedProduct(string name, double price, double customFree )
            : base(name, price)
        {
            _customFree = customFree;
        }

        //Get e Set
        public double GetCustomFree() {

            return _customFree;

        }

        public void SetCustomFree(double customFree){

            _customFree = customFree;

        }

        //method

        public double TotalPrice(double price) {

            return price + _customFree;

        }

        /*sobrescrevendo o method da classe principal*/
        public override string PriceTag()
        {
            return "Name Product: " 
                + GetName() 
                + " $" 
                + TotalPrice(GetPrice()).ToString("F2", CultureInfo.InvariantCulture)
                + " ("
                + GetCustomFree().ToString("F2", CultureInfo.InvariantCulture)
                + ") ";
        }
    }
}
