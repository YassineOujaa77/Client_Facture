namespace clent_facture
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
            this.designationn = new MetroFramework.Controls.MetroTextBox();
            this.referencee = new MetroFramework.Controls.MetroTextBox();
            this.quantite = new MetroFramework.Controls.MetroTextBox();
            this.prix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.des = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prixx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ttc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rfc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox7 = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // designationn
            // 
            this.designationn.Location = new System.Drawing.Point(165, 106);
            this.designationn.Name = "designationn";
            this.designationn.Size = new System.Drawing.Size(255, 41);
            this.designationn.TabIndex = 0;
            // 
            // referencee
            // 
            this.referencee.Location = new System.Drawing.Point(165, 182);
            this.referencee.Name = "referencee";
            this.referencee.Size = new System.Drawing.Size(255, 41);
            this.referencee.TabIndex = 1;
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(165, 252);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(168, 41);
            this.quantite.TabIndex = 2;
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(165, 329);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(168, 41);
            this.prix.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Designation";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 182);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Reference";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(34, 252);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(78, 25);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Quantité";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 329);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 20);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Prix";
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(69, 26);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(42, 17);
            this.metroRadioButton1.TabIndex = 8;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "7%";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(69, 68);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(49, 17);
            this.metroRadioButton2.TabIndex = 9;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "20%";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroRadioButton2);
            this.metroPanel1.Controls.Add(this.metroRadioButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(779, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(276, 104);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 26);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 20);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Tva";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.des,
            this.Prixx,
            this.quant,
            this.ht,
            this.tva,
            this.ttc,
            this.rfc});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(457, 252);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 241);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // des
            // 
            this.des.Text = "Designation";
            this.des.Width = 90;
            // 
            // Prixx
            // 
            this.Prixx.Text = "Prix";
            // 
            // quant
            // 
            this.quant.Text = "Quantité";
            this.quant.Width = 85;
            // 
            // ht
            // 
            this.ht.Text = "Montant_HT";
            this.ht.Width = 85;
            // 
            // tva
            // 
            this.tva.Text = "Montant TVA";
            this.tva.Width = 90;
            // 
            // ttc
            // 
            this.ttc.Text = "Total(TTC)";
            this.ttc.Width = 90;
            // 
            // rfc
            // 
            this.rfc.Text = "Reference";
            this.rfc.Width = 90;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(457, 647);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 57);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Valider";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(714, 647);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 57);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Modifier";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(955, 647);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(100, 57);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Quitter";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 15;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(439, 529);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(145, 20);
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Montant Total (Dh)";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(683, 529);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(173, 20);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "TVA (7% ou 20%) (Dh):";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(935, 529);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(139, 20);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Total à Payer (Dh):";
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox5.Location = new System.Drawing.Point(439, 576);
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.Size = new System.Drawing.Size(187, 27);
            this.metroTextBox5.TabIndex = 19;
            this.metroTextBox5.Text = "0";
            this.metroTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTextBox6
            // 
            this.metroTextBox6.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox6.Location = new System.Drawing.Point(683, 576);
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.Size = new System.Drawing.Size(194, 27);
            this.metroTextBox6.TabIndex = 20;
            this.metroTextBox6.Text = "0";
            this.metroTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroTextBox7
            // 
            this.metroTextBox7.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox7.Location = new System.Drawing.Point(935, 576);
            this.metroTextBox7.Name = "metroTextBox7";
            this.metroTextBox7.Size = new System.Drawing.Size(169, 27);
            this.metroTextBox7.TabIndex = 21;
            this.metroTextBox7.Text = "0";
            this.metroTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 725);
            this.Controls.Add(this.metroTextBox7);
            this.Controls.Add(this.metroTextBox6);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.referencee);
            this.Controls.Add(this.designationn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox designationn;
        private MetroFramework.Controls.MetroTextBox referencee;
        private MetroFramework.Controls.MetroTextBox quantite;
        private MetroFramework.Controls.MetroTextBox prix;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader des;
        private System.Windows.Forms.ColumnHeader Prixx;
        private System.Windows.Forms.ColumnHeader quant;
        private System.Windows.Forms.ColumnHeader ht;
        private System.Windows.Forms.ColumnHeader tva;
        private System.Windows.Forms.ColumnHeader ttc;
        private System.Windows.Forms.ColumnHeader rfc;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroTextBox metroTextBox7;
    }
}

