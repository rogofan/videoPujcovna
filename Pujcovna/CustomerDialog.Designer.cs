namespace Pujcovna
{
    partial class CustomerDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.txtPrijmeni = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.numRok = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnStorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Příjmení:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rok narození:";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(114, 20);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(171, 20);
            this.txtJmeno.TabIndex = 4;
            // 
            // txtPrijmeni
            // 
            this.txtPrijmeni.Location = new System.Drawing.Point(114, 52);
            this.txtPrijmeni.Name = "txtPrijmeni";
            this.txtPrijmeni.Size = new System.Drawing.Size(171, 20);
            this.txtPrijmeni.TabIndex = 5;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(114, 81);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(171, 20);
            this.txtAdresa.TabIndex = 6;
            // 
            // numRok
            // 
            this.numRok.Location = new System.Drawing.Point(114, 110);
            this.numRok.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numRok.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numRok.Name = "numRok";
            this.numRok.Size = new System.Drawing.Size(120, 20);
            this.numRok.TabIndex = 7;
            this.numRok.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(58, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnStorno
            // 
            this.btnStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStorno.Location = new System.Drawing.Point(170, 165);
            this.btnStorno.Name = "btnStorno";
            this.btnStorno.Size = new System.Drawing.Size(75, 23);
            this.btnStorno.TabIndex = 9;
            this.btnStorno.Text = "Storno";
            this.btnStorno.UseVisualStyleBackColor = true;
            this.btnStorno.Click += new System.EventHandler(this.btnStorno_Click);
            // 
            // CustomerDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 212);
            this.Controls.Add(this.btnStorno);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numRok);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrijmeni);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDialog";
            this.Text = "Zákazník";
            this.VisibleChanged += new System.EventHandler(this.CustomerDialog_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.TextBox txtPrijmeni;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.NumericUpDown numRok;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnStorno;
    }
}