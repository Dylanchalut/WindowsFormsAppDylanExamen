using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDylanExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajouterOuSoupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterSoupprimerPizza Eenfant = new AjouterSoupprimerPizza();
            Eenfant.MdiParent = this;
            Eenfant.Show();
        }

        private void modifierCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierCommande fenfant = new ModifierCommande();
            fenfant.MdiParent = this;
            fenfant.Show();
        }

        private void afficherCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherCommande Aenfant = new AfficherCommande();
            Aenfant.MdiParent = this;
            Aenfant.Show();
        }
    }
}
