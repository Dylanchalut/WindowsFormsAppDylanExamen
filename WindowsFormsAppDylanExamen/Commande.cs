using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsAppDylanExamen
{
    public class Commande
    {
        //attributs
        private string commandeID;
        private DateTime dateCommande;
        private int quantite;
        private Pizza unePizza;

        public Commande(string p_commandeID ="", DateTime p_dateCommande = default(DateTime), int p_quantite = 0) 
        {
            this.commandeID = p_commandeID;
            this.dateCommande = p_dateCommande;
            this.quantite = p_quantite;
        }

        public string CommandeID
        {
            get { return commandeID; }
            set {
                Regex R = new Regex("^[A-Za-z]{1}[0-9]{5}$");
                if (R.IsMatch(value) == true)commandeID = value;
                }
        }

        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { if (value > 0) quantite = value; }
        }

        public Pizza UnePizza
        {
            get { return unePizza; }
            set { unePizza = value; }
        }

        public float Calculer_prix_commnde()
        {
            UnePizza.PrixPizza * (0.00975 + 0.05);
            
        }
    }
}
