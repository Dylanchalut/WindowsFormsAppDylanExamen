namespace WindowsFormsAppDylanExamen
{
    partial class ModifierCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label_commande_id = new System.Windows.Forms.Label();
            this.textBox_commandeID = new System.Windows.Forms.TextBox();
            this.button_modifier = new System.Windows.Forms.Button();
            this.textBox_quantite = new System.Windows.Forms.TextBox();
            this.label_quantite = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_commande = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(47, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(693, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // label_commande_id
            // 
            this.label_commande_id.AutoSize = true;
            this.label_commande_id.Location = new System.Drawing.Point(65, 55);
            this.label_commande_id.Name = "label_commande_id";
            this.label_commande_id.Size = new System.Drawing.Size(74, 13);
            this.label_commande_id.TabIndex = 2;
            this.label_commande_id.Text = "Commande ID";
            // 
            // textBox_commandeID
            // 
            this.textBox_commandeID.Location = new System.Drawing.Point(168, 52);
            this.textBox_commandeID.Name = "textBox_commandeID";
            this.textBox_commandeID.Size = new System.Drawing.Size(200, 20);
            this.textBox_commandeID.TabIndex = 3;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(168, 189);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(200, 42);
            this.button_modifier.TabIndex = 4;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // textBox_quantite
            // 
            this.textBox_quantite.Location = new System.Drawing.Point(168, 98);
            this.textBox_quantite.Name = "textBox_quantite";
            this.textBox_quantite.Size = new System.Drawing.Size(200, 20);
            this.textBox_quantite.TabIndex = 5;
            // 
            // label_quantite
            // 
            this.label_quantite.AutoSize = true;
            this.label_quantite.Location = new System.Drawing.Point(65, 105);
            this.label_quantite.Name = "label_quantite";
            this.label_quantite.Size = new System.Drawing.Size(47, 13);
            this.label_quantite.TabIndex = 6;
            this.label_quantite.Text = "Quantité";
            this.label_quantite.Click += new System.EventHandler(this.label1_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "CommandeID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Quantite";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DateCommande";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "PizzaID";
            this.Column4.Name = "Column4";
            // 
            // dateTimePicker_commande
            // 
            this.dateTimePicker_commande.Location = new System.Drawing.Point(168, 141);
            this.dateTimePicker_commande.Name = "dateTimePicker_commande";
            this.dateTimePicker_commande.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_commande.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(65, 147);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(86, 13);
            this.label_date.TabIndex = 9;
            this.label_date.Text = "Date Commande";
            // 
            // ModifierCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_commande);
            this.Controls.Add(this.label_quantite);
            this.Controls.Add(this.textBox_quantite);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.textBox_commandeID);
            this.Controls.Add(this.label_commande_id);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ModifierCommande";
            this.Text = "ModifierCommande";
            this.Load += new System.EventHandler(this.ModifierCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label_commande_id;
        private System.Windows.Forms.TextBox textBox_commandeID;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.TextBox textBox_quantite;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_commande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_date;
    }
}