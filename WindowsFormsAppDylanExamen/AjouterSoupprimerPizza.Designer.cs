namespace WindowsFormsAppDylanExamen
{
    partial class AjouterSoupprimerPizza
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_PizzaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_pizza_id = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_prix = new System.Windows.Forms.Label();
            this.textBox_ID_pizza = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.numericUpDown_prix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PizzaID,
            this.Column_type,
            this.Column_prix});
            this.dataGridView1.Location = new System.Drawing.Point(41, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column_PizzaID
            // 
            this.Column_PizzaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_PizzaID.HeaderText = "PizzaID";
            this.Column_PizzaID.Name = "Column_PizzaID";
            // 
            // Column_type
            // 
            this.Column_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_type.HeaderText = "Type";
            this.Column_type.Name = "Column_type";
            // 
            // Column_prix
            // 
            this.Column_prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_prix.HeaderText = "Prix";
            this.Column_prix.Name = "Column_prix";
            // 
            // label_pizza_id
            // 
            this.label_pizza_id.AutoSize = true;
            this.label_pizza_id.Location = new System.Drawing.Point(94, 50);
            this.label_pizza_id.Name = "label_pizza_id";
            this.label_pizza_id.Size = new System.Drawing.Size(46, 13);
            this.label_pizza_id.TabIndex = 2;
            this.label_pizza_id.Text = "Pizza ID";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(94, 79);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(59, 13);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Type Pizza";
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Location = new System.Drawing.Point(94, 123);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(52, 13);
            this.label_prix.TabIndex = 4;
            this.label_prix.Text = "Prix Pizza";
            // 
            // textBox_ID_pizza
            // 
            this.textBox_ID_pizza.Location = new System.Drawing.Point(182, 43);
            this.textBox_ID_pizza.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_ID_pizza.Name = "textBox_ID_pizza";
            this.textBox_ID_pizza.Size = new System.Drawing.Size(103, 20);
            this.textBox_ID_pizza.TabIndex = 5;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Neapolitan Pizza",
            "Chicago Pizza",
            "Greek Pizza"});
            this.comboBox_type.Location = new System.Drawing.Point(182, 79);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(100, 21);
            this.comboBox_type.TabIndex = 7;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(182, 151);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(103, 36);
            this.button_ajouter.TabIndex = 8;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(182, 202);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(103, 36);
            this.button_supprimer.TabIndex = 9;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // numericUpDown_prix
            // 
            this.numericUpDown_prix.Location = new System.Drawing.Point(182, 116);
            this.numericUpDown_prix.Name = "numericUpDown_prix";
            this.numericUpDown_prix.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown_prix.TabIndex = 10;
            // 
            // AjouterSoupprimerPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown_prix);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_ID_pizza);
            this.Controls.Add(this.label_prix);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_pizza_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AjouterSoupprimerPizza";
            this.Text = "AjouterSoupprimerPizza";
            this.Load += new System.EventHandler(this.AjouterSoupprimerPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_pizza_id;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.TextBox textBox_ID_pizza;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.NumericUpDown numericUpDown_prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PizzaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_prix;
    }
}