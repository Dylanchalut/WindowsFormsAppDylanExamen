using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDylanExamen
{
    //classe qui est static
    static class Outils
    {
        //attribut
        private static List<Commande> list_commandes;
        private static List<Pizza> list_pizza;
       
        public static List<Commande> listCommandes
        {
            get { return list_commandes; }
            set { list_commandes = value; }
        }

        public static List<Pizza> listPizza
        {
            get { return list_pizza; }
            set { list_pizza = value; }
        }

        /*static public List<Commande> Chercher_commande(int p_quantite)
        {
            List<string> l_commande = new List<string>();
            foreach (Commande e in listCommandes)
            {
                if (e.Quantite > p_quantite){
                    l_commande.Add(Convert.ToString(e));
                    return l_commande;

            }
        }*/
    }
}
