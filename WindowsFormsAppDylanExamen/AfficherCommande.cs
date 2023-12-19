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
    public partial class AfficherCommande : Form
    {
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;
        String Query;
        public AfficherCommande()
        {
            InitializeComponent();
        }

        private void AfficherCommande_Load(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;



                Query = "Exec obtenir_commandes_apres_date @date = '16-12-2023'";
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
                            dataGridView3.Rows.Add(resultat[0], resultat[1], resultat[2], resultat[3]);
                        }
                    }
                    else
                        MessageBox.Show("La table Commande est vide.");
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

        private void dataGridView_Pizza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
