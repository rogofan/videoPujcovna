namespace Pujcovna
{
    partial class Form1
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
            this.dgvZakaznici = new System.Windows.Forms.DataGridView();
            this.dgvSklad = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVypujcene = new System.Windows.Forms.DataGridView();
            this.btnVypujcit = new System.Windows.Forms.Button();
            this.btnVratit = new System.Windows.Forms.Button();
            this.btnNovyZakaznik = new System.Windows.Forms.Button();
            this.btnEditZakaznik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypujcene)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zákazníci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sklad:";
            // 
            // dgvZakaznici
            // 
            this.dgvZakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaznici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvZakaznici.Location = new System.Drawing.Point(12, 25);
            this.dgvZakaznici.MultiSelect = false;
            this.dgvZakaznici.Name = "dgvZakaznici";
            this.dgvZakaznici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZakaznici.Size = new System.Drawing.Size(462, 299);
            this.dgvZakaznici.TabIndex = 2;
            this.dgvZakaznici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZakaznici_CellContentClick);
            this.dgvZakaznici.SelectionChanged += new System.EventHandler(this.DgvZakaznici_SelectionChanged);
            // 
            // dgvSklad
            // 
            this.dgvSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSklad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSklad.Location = new System.Drawing.Point(675, 27);
            this.dgvSklad.MultiSelect = false;
            this.dgvSklad.Name = "dgvSklad";
            this.dgvSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSklad.Size = new System.Drawing.Size(465, 296);
            this.dgvSklad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vypůjčené položky:";
            // 
            // dgvVypujcene
            // 
            this.dgvVypujcene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVypujcene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVypujcene.Location = new System.Drawing.Point(15, 356);
            this.dgvVypujcene.MultiSelect = false;
            this.dgvVypujcene.Name = "dgvVypujcene";
            this.dgvVypujcene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVypujcene.Size = new System.Drawing.Size(911, 178);
            this.dgvVypujcene.TabIndex = 5;
            // 
            // btnVypujcit
            // 
            this.btnVypujcit.Location = new System.Drawing.Point(489, 27);
            this.btnVypujcit.Name = "btnVypujcit";
            this.btnVypujcit.Size = new System.Drawing.Size(170, 59);
            this.btnVypujcit.TabIndex = 6;
            this.btnVypujcit.Text = "Vypůjčit";
            this.btnVypujcit.UseVisualStyleBackColor = true;
            this.btnVypujcit.Click += new System.EventHandler(this.BtnVypujcit_Click);
            // 
            // btnVratit
            // 
            this.btnVratit.Location = new System.Drawing.Point(489, 92);
            this.btnVratit.Name = "btnVratit";
            this.btnVratit.Size = new System.Drawing.Size(170, 60);
            this.btnVratit.TabIndex = 7;
            this.btnVratit.Text = "Vrátit";
            this.btnVratit.UseVisualStyleBackColor = true;
            this.btnVratit.Click += new System.EventHandler(this.BtnVratit_Click);
            // 
            // btnNovyZakaznik
            // 
            this.btnNovyZakaznik.Location = new System.Drawing.Point(943, 357);
            this.btnNovyZakaznik.Name = "btnNovyZakaznik";
            this.btnNovyZakaznik.Size = new System.Drawing.Size(197, 29);
            this.btnNovyZakaznik.TabIndex = 8;
            this.btnNovyZakaznik.Text = "Přidat zákazníka";
            this.btnNovyZakaznik.UseVisualStyleBackColor = true;
            this.btnNovyZakaznik.Click += new System.EventHandler(this.BtnNovyZakaznik_Click);
            // 
            // btnEditZakaznik
            // 
            this.btnEditZakaznik.Location = new System.Drawing.Point(944, 392);
            this.btnEditZakaznik.Name = "btnEditZakaznik";
            this.btnEditZakaznik.Size = new System.Drawing.Size(196, 30);
            this.btnEditZakaznik.TabIndex = 9;
            this.btnEditZakaznik.Text = "Editovat zákazníka";
            this.btnEditZakaznik.UseVisualStyleBackColor = true;
            this.btnEditZakaznik.Click += new System.EventHandler(this.BtnEditZakaznik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 544);
            this.Controls.Add(this.btnEditZakaznik);
            this.Controls.Add(this.btnNovyZakaznik);
            this.Controls.Add(this.btnVratit);
            this.Controls.Add(this.btnVypujcit);
            this.Controls.Add(this.dgvVypujcene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSklad);
            this.Controls.Add(this.dgvZakaznici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Půjčovna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypujcene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvZakaznici;
        private System.Windows.Forms.DataGridView dgvSklad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVypujcene;
        private System.Windows.Forms.Button btnVypujcit;
        private System.Windows.Forms.Button btnVratit;
        private System.Windows.Forms.Button btnNovyZakaznik;
        private System.Windows.Forms.Button btnEditZakaznik;
    }
}

