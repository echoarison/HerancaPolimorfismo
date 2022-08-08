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
        private double _customFee;

        //Construtor
        public ImportedProduct() 
        {

        }

        //aqui o construtor esta herdadando a base da Class Product
        public ImportedProduct(string name, double price, double customFee )
            : base(name, price)
        {
            _customFee = customFee;
        }

        //Get e Set
        public double GetCustomFee() {

            return _customFee;

        }

        public void SetCustomFee(double customFee){

            _customFee = customFee;

        }

        //method

        public double TotalPrice(double price) {

            return price + _customFee;

        }

        /*sobrescrevendo o method da classe principal*/
        public override string PriceTag()
        {
            return "Name Product: " 
                + GetName() 
                + " $" 
                + TotalPrice(GetPrice()).ToString("F2", CultureInfo.InvariantCulture)
                + " ("
                + GetCustomFee().ToString("F2", CultureInfo.InvariantCulture)
                + ") ";
        }
    }
}
