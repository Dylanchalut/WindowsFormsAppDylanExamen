namespace WindowsFormsAppDylanExamen
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterOuSoupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterOuSoupprimerToolStripMenuItem,
            this.modifierCommandeToolStripMenuItem,
            this.afficherCommandesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterOuSoupprimerToolStripMenuItem
            // 
            this.ajouterOuSoupprimerToolStripMenuItem.Name = "ajouterOuSoupprimerToolStripMenuItem";
            this.ajouterOuSoupprimerToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.ajouterOuSoupprimerToolStripMenuItem.Text = "Ajouter ou Soupprimer Pizza";
            this.ajouterOuSoupprimerToolStripMenuItem.Click += new System.EventHandler(this.ajouterOuSoupprimerToolStripMenuItem_Click);
            // 
            // modifierCommandeToolStripMenuItem
            // 
            this.modifierCommandeToolStripMenuItem.Name = "modifierCommandeToolStripMenuItem";
            this.modifierCommandeToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.modifierCommandeToolStripMenuItem.Text = "Modifier Commande";
            this.modifierCommandeToolStripMenuItem.Click += new System.EventHandler(this.modifierCommandeToolStripMenuItem_Click);
            // 
            // afficherCommandesToolStripMenuItem
            // 
            this.afficherCommandesToolStripMenuItem.Name = "afficherCommandesToolStripMenuItem";
            this.afficherCommandesToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.afficherCommandesToolStripMenuItem.Text = "Afficher Commandes";
            this.afficherCommandesToolStripMenuItem.Click += new System.EventHandler(this.afficherCommandesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterOuSoupprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherCommandesToolStripMenuItem;
    }
}

