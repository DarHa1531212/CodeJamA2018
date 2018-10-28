namespace winformsJam
{
    partial class Dons
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
            this.components = new System.ComponentModel.Container();
            this.DemandeNom = new System.Windows.Forms.Label();
            this.ListeEmployes = new System.Windows.Forms.ComboBox();
            this.DonDeGold = new System.Windows.Forms.NumericUpDown();
            this.NoEmploye = new System.Windows.Forms.ListBox();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DonDeGold)).BeginInit();
     //       ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DemandeNom
            // 
            this.DemandeNom.AutoSize = true;
            this.DemandeNom.Location = new System.Drawing.Point(13, 13);
            this.DemandeNom.Name = "DemandeNom";
            this.DemandeNom.Size = new System.Drawing.Size(195, 13);
            this.DemandeNom.TabIndex = 0;
            this.DemandeNom.Text = "Entez le nom du récipient de votre don: ";
            this.DemandeNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListeEmployes
            // 
            this.ListeEmployes.DataSource = this.tblUserBindingSource;
            this.ListeEmployes.FormattingEnabled = true;
            this.ListeEmployes.Location = new System.Drawing.Point(214, 5);
            this.ListeEmployes.Name = "ListeEmployes";
            this.ListeEmployes.Size = new System.Drawing.Size(121, 21);
            this.ListeEmployes.TabIndex = 2;
            // 
            // DonDeGold
            // 
            this.DonDeGold.Location = new System.Drawing.Point(452, 6);
            this.DonDeGold.Name = "DonDeGold";
            this.DonDeGold.Size = new System.Drawing.Size(41, 20);
            this.DonDeGold.TabIndex = 3;
            // 
            // NoEmploye
            // 
            this.NoEmploye.FormattingEnabled = true;
            this.NoEmploye.Location = new System.Drawing.Point(341, 5);
            this.NoEmploye.Name = "NoEmploye";
            this.NoEmploye.Size = new System.Drawing.Size(74, 17);
            this.NoEmploye.TabIndex = 4;
            // 
            // databaseDataSet
            // 
        //    this.databaseDataSet.DataSetName = "DatabaseDataSet";
         //   this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
          //  this.tblUserBindingSource.DataSource = this.databaseDataSet;
            // 
            // tblUserTableAdapter
            // 
       //     this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // Dons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 555);
            this.Controls.Add(this.NoEmploye);
            this.Controls.Add(this.DonDeGold);
            this.Controls.Add(this.ListeEmployes);
            this.Controls.Add(this.DemandeNom);
            this.Name = "Dons";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonDeGold)).EndInit();
       //     ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DemandeNom;
        private System.Windows.Forms.ComboBox ListeEmployes;
        private System.Windows.Forms.NumericUpDown DonDeGold;
        private System.Windows.Forms.ListBox NoEmploye;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
    }
}