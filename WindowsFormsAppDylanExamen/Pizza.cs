using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsAppDylanExamen
{
    public class Pizza
    {
        //Attribut
        private string pizzaID;
        private string typePizza;
        private int prixPzza;

        //constructeur avec parametre défaut
        public Pizza(string p_pizzaID = "", string p_typePizza = "", int p_prixPzza = 0)
        {
            this.pizzaID = p_pizzaID;
            this.typePizza = p_typePizza;
            this.prixPzza = p_prixPzza;
        }

        public string PizzaID
        {
            get { return pizzaID; }
            set
            {
                Regex R = new Regex("^[0-9]{3}$");
                if (R.IsMatch(value) == true) pizzaID = value;
            }
                
        }

        public string TypePizza
        {
            get { return typePizza; }
            set { if (value == "Neapolitan Pizza" || value == "Chicago Pizza" || value == "Greek Pizza") typePizza = value; }
        }

        public int PrixPizza
        {
            get { return prixPzza; }
            set {
                if  (value > 0 ) prixPzza = value; }
        }
    }
}
