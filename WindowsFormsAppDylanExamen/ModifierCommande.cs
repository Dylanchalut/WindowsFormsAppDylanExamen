using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsAppDylanExamen
{
    public partial class ModifierCommande : Form
    {
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;
        String Query;
        public ModifierCommande()
        {
            InitializeComponent();
        }

        private void ModifierCommande_Load(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;



                Query = "Select * from Commandes";
                command = new SqlCommand(Query, cnx);
                //Ouvrir la connexion avec la Base de données

                try
                {
                    cnx.Open();
                    //Résultat
                    resultat = command.ExecuteReader();
                    //resultat est une table avec des lignes et des colonnes
                    //On va boucler sur cette table

                    if (resultat.HasRows) //On vérifie si la table n'est pas vide
                    {
                        while (resultat.Read()) // Tant qu'il y a des lignes à lire
                        {
                            dataGridView2.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3]);
                        }
                    }
                    else
                        MessageBox.Show("La table Commandes est vide.");
                    //Fermeture du DataReader
                    resultat.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnx.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                // Attention aux injections sql !
                // Entrer pour le prenom ceci : Hasna');Drop Table Etudiant -- 
                // Il faut donc réécrire ce code en utilisant  des paramètres pour les commandes !
                // Voir la solution ci-bas dans le gestionnaire d'événement du bouton Supprimer 
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
                //Écrire la commande
                Query = "ALTER TABLE Commandes (CommandesID, Nb_Pizzas, Date_Commande) values (" + textBox_commandeID.Text.Trim() +
                           ",'" + textBox_quantite.Text.Trim() + "" + "','" + dateTimePicker_commande.Text.Trim() + "');";
                ;
                command.Connection = cnx;

                command.CommandText = Query;

            
            }
        }
    }
}
