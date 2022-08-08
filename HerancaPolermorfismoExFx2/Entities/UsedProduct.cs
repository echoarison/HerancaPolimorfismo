using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolermorfismoExFx2.Entities
{
    /**
     * 
     * Vai herdar da Class Product
     * os atributos e methods
     * 
     * */
    internal class UsedProduct : Product
    {
        //atributo
        private DateTime _manuFactureDate;

        //Construtor
        public UsedProduct() 
        {
            
        }

        public UsedProduct(string name, double price, DateTime manuFactureDate)
            : base(name, price)
        {

            _manuFactureDate = manuFactureDate;

        }

        //get e set
        public DateTime GetManuFactureDate() 
        {

            return _manuFactureDate;

        }

        public void SetManuFactureDate(DateTime manuFactureDate) 
        {
            _manuFactureDate = manuFactureDate;
        }

        //methods

        /*sobrescrevendo o method da classe principal*/
        public override string PriceTag()
        {
            return "Name Product: "
                + GetName()
                + "(used)"
                + " $"
                + GetPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + GetManuFactureDate().ToString("dd/MM/yyyy")
                +")";
        }
    }
}
