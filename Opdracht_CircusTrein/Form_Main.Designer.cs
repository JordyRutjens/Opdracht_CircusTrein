namespace Opdracht_CircusTrein
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tctMain = new System.Windows.Forms.TabControl();
            this.tbpAddAnimals = new System.Windows.Forms.TabPage();
            this.lsbAnimalsInQ = new System.Windows.Forms.ListBox();
            this.lblOutputAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnimalSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.tbpTrain = new System.Windows.Forms.TabPage();
            this.lsbCurrentAnimals = new System.Windows.Forms.ListBox();
            this.lsbTrainMain = new System.Windows.Forms.ListBox();
            this.tctMain.SuspendLayout();
            this.tbpAddAnimals.SuspendLayout();
            this.tbpTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctMain
            // 
            this.tctMain.Controls.Add(this.tbpAddAnimals);
            this.tctMain.Controls.Add(this.tbpTrain);
            this.tctMain.Location = new System.Drawing.Point(11, 2);
            this.tctMain.Margin = new System.Windows.Forms.Padding(4);
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
            this.tctMain.Size = new System.Drawing.Size(660, 265);
            this.tctMain.TabIndex = 0;
            // 
            // tbpAddAnimals
            // 
            this.tbpAddAnimals.Controls.Add(this.lsbAnimalsInQ);
            this.tbpAddAnimals.Controls.Add(this.lblOutputAdd);
            this.tbpAddAnimals.Controls.Add(this.label2);
            this.tbpAddAnimals.Controls.Add(this.cmbAnimalSize);
            this.tbpAddAnimals.Controls.Add(this.label1);
            this.tbpAddAnimals.Controls.Add(this.cmbAnimalType);
            this.tbpAddAnimals.Controls.Add(this.btnAddAnimal);
            this.tbpAddAnimals.Location = new System.Drawing.Point(4, 25);
            this.tbpAddAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.tbpAddAnimals.Name = "tbpAddAnimals";
            this.tbpAddAnimals.Padding = new System.Windows.Forms.Padding(4);
            this.tbpAddAnimals.Size = new System.Drawing.Size(652, 236);
            this.tbpAddAnimals.TabIndex = 0;
            this.tbpAddAnimals.Text = "Add Animals";
            this.tbpAddAnimals.UseVisualStyleBackColor = true;
            // 
            // lsbAnimalsInQ
            // 
            this.lsbAnimalsInQ.FormattingEnabled = true;
            this.lsbAnimalsInQ.ItemHeight = 16;
            this.lsbAnimalsInQ.Location = new System.Drawing.Point(12, 59);
            this.lsbAnimalsInQ.Margin = new System.Windows.Forms.Padding(4);
            this.lsbAnimalsInQ.Name = "lsbAnimalsInQ";
            this.lsbAnimalsInQ.Size = new System.Drawing.Size(523, 164);
            this.lsbAnimalsInQ.TabIndex = 7;
            // 
            // lblOutputAdd
            // 
            this.lblOutputAdd.AutoSize = true;
            this.lblOutputAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOutputAdd.Location = new System.Drawing.Point(8, 55);
            this.lblOutputAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputAdd.Name = "lblOutputAdd";
            this.lblOutputAdd.Size = new System.Drawing.Size(0, 17);
            this.lblOutputAdd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Format";
            // 
            // cmbAnimalSize
            // 
            this.cmbAnimalSize.FormattingEnabled = true;
            this.cmbAnimalSize.Items.AddRange(new object[] {
            ""});
            this.cmbAnimalSize.Location = new System.Drawing.Point(203, 26);
            this.cmbAnimalSize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnimalSize.Name = "cmbAnimalSize";
            this.cmbAnimalSize.Size = new System.Drawing.Size(160, 24);
            this.cmbAnimalSize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eater";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(12, 26);
            this.cmbAnimalType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(160, 24);
            this.cmbAnimalType.TabIndex = 2;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(391, 26);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(145, 26);
            this.btnAddAnimal.TabIndex = 1;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // tbpTrain
            // 
            this.tbpTrain.Controls.Add(this.lsbCurrentAnimals);
            this.tbpTrain.Controls.Add(this.lsbTrainMain);
            this.tbpTrain.Location = new System.Drawing.Point(4, 25);
            this.tbpTrain.Margin = new System.Windows.Forms.Padding(4);
            this.tbpTrain.Name = "tbpTrain";
            this.tbpTrain.Padding = new System.Windows.Forms.Padding(4);
            this.tbpTrain.Size = new System.Drawing.Size(652, 236);
            this.tbpTrain.TabIndex = 1;
            this.tbpTrain.Text = "Train";
            this.tbpTrain.UseVisualStyleBackColor = true;
            // 
            // lsbCurrentAnimals
            // 
            this.lsbCurrentAnimals.FormattingEnabled = true;
            this.lsbCurrentAnimals.ItemHeight = 16;
            this.lsbCurrentAnimals.Location = new System.Drawing.Point(311, 7);
            this.lsbCurrentAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.lsbCurrentAnimals.Name = "lsbCurrentAnimals";
            this.lsbCurrentAnimals.Size = new System.Drawing.Size(329, 212);
            this.lsbCurrentAnimals.TabIndex = 4;
            // 
            // lsbTrainMain
            // 
            this.lsbTrainMain.FormattingEnabled = true;
            this.lsbTrainMain.ItemHeight = 16;
            this.lsbTrainMain.Location = new System.Drawing.Point(8, 7);
            this.lsbTrainMain.Margin = new System.Windows.Forms.Padding(4);
            this.lsbTrainMain.Name = "lsbTrainMain";
            this.lsbTrainMain.Size = new System.Drawing.Size(293, 212);
            this.lsbTrainMain.TabIndex = 3;
            this.lsbTrainMain.SelectedIndexChanged += new System.EventHandler(this.lsbTrainMain_SelectedIndexChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 274);
            this.Controls.Add(this.tctMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.Text = "Circus Trein";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tctMain.ResumeLayout(false);
            this.tbpAddAnimals.ResumeLayout(false);
            this.tbpAddAnimals.PerformLayout();
            this.tbpTrain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctMain;
        private System.Windows.Forms.TabPage tbpAddAnimals;
        private System.Windows.Forms.TabPage tbpTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnimalSize;
        private System.Windows.Forms.Label lblOutputAdd;
        private System.Windows.Forms.ListBox lsbTrainMain;
        private System.Windows.Forms.ListBox lsbCurrentAnimals;
        private System.Windows.Forms.ListBox lsbAnimalsInQ;
    }
}

