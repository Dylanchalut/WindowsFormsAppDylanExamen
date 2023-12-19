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
    public partial class AjouterSoupprimerPizza : Form
    {
        SqlConnection cnx;
        SqlCommand command;
        SqlDataReader resultat;
        String Query;
        int position = -1;

        public AjouterSoupprimerPizza()
        {
            InitializeComponent();
        }

        private void AjouterSoupprimerPizza_Load(object sender, EventArgs e)
        {
            using (cnx = new SqlConnection())
            {
                cnx.ConnectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

              

                Query = "Select * from Pizzas";
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
                            dataGridView1.Rows.Add(resultat[0], resultat[1], resultat[2]);
                        }
                    }
                    else
                        MessageBox.Show("La table Pizzas est vide.");
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
        public bool VerifierChampsVide()
        {
            if (string.IsNullOrEmpty(textBox_ID_pizza.Text) || string.IsNullOrEmpty(comboBox_type.Text) || numericUpDown_prix.Text == "0")
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return false;
            }
            return true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza();
            p.PizzaID = textBox_ID_pizza.Text;
            p.TypePizza = comboBox_type.Text;
            p.PrixPizza = Convert.ToInt32(numericUpDown_prix.Text);
            if (p.PizzaID != textBox_ID_pizza.Text)
            {
                MessageBox.Show("PizzaID doit être une chaine de caractères numériques de longueur égale à 3");
                textBox_ID_pizza.Text = "";
            }
           

            if (p.TypePizza != comboBox_type.Text)
            {
                MessageBox.Show("Veuillez selectionner une option");
                comboBox_type.Text = "";
            }
            

            if (p.PrixPizza != Convert.ToInt32(numericUpDown_prix.Text))
            {
                MessageBox.Show("Doit être supérieur à 0");
                numericUpDown_prix.Text = "";
            }



            if (p.PizzaID == textBox_ID_pizza.Text && p.TypePizza == comboBox_type.Text && p.PrixPizza == Convert.ToInt32(numericUpDown_prix.Text) && VerifierChampsVide())
            {
                try
                {
                    String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

                    SqlConnection cnx = new SqlConnection();
                    cnx.ConnectionString = connectionString;
                    cnx.Open();
                    //Écrire la commande
                    //Préparer la commande INSERT dans la variable Query 
                    string Query = "INSERT INTO Pizzas (PizzaID, Type_Pizza, Prix_Pizza) values (" + textBox_ID_pizza.Text.Trim() +
                                    ",'" + comboBox_type.Text.Trim() + "" + "','" + numericUpDown_prix.Text.Trim() + "');";
                    SqlCommand command = new SqlCommand(Query, cnx);
                    //Mettre La requête dans la propriété CommanText de l’objet command
                    command.CommandText = Query;

                    //Rétablir la connexion avec le serveur si elle a été fermée
                    if (cnx.State == ConnectionState.Open)
                    {
                        //ConnectionState dans System.Data
                        cnx.Close();
                    }
                    cnx.Open();
                    dataGridView1.Rows.Add(textBox_ID_pizza.Text, comboBox_type.Text, numericUpDown_prix.Text);
                    //Executer la commande INSERT
                    command.Parameters.AddWithValue("@PizzaID", textBox_ID_pizza.Text);
                    command.Parameters.AddWithValue("@Type_Pizza", comboBox_type.Text);
                    command.Parameters.AddWithValue("@Prix_Pizza", numericUpDown_prix.Text);
                    int nombreLignes = command.ExecuteNonQuery();
                    MessageBox.Show(nombreLignes + "ligne(s) affectée(s)");
                    button_ajouter_Click(sender, e);

                    cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur");
                }
            }


        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            SqlCommand commande = new SqlCommand();
            commande.CommandText = "Delete From Pizzas where PizzaID=@PizzaID";
            commande.Parameters.AddWithValue("@PizzaID", Column_PizzaID);
            //Rétablir la connexion avec le serveur si elle est fermée   
            if (cnx.State == ConnectionState.Open)
            {
                //ConnectionState dans System.Data
                cnx.Close();
            }
            cnx.Open();
            commande.ExecuteNonQuery();
            dataGridView1.Rows.RemoveAt(position);
            cnx.Close();
        }
    }
}
