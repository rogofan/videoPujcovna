using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pujcovna
{
    public partial class Form1 : Form
    {
        CustomerDialog zakaznikDialog = new CustomerDialog();

        public Form1()
        {
            InitializeComponent();
            //natažení dat do dataGridů
            dgvZakaznici.DataSource = Databaze.Zakaznici;
            dgvSklad.DataSource = Databaze.Sklad;
        }

        private void SetButtons()
        {
            //Buttny budou disable-šedivý když nebude mít smysl je použít = není co pujčít/není co vrátit
            btnVypujcit.Enabled = (dgvSklad.Rows.Count > 0);
            btnVratit.Enabled = (dgvVypujcene.Rows.Count > 0);
        }
        //Aby se vždy zobrazily ty zápůjčky co mají. To znamená, že ten kterého selectnu(zákazníka) tak toho vidím zápůjčky.
        private void DgvZakaznici_SelectionChanged(object sender, EventArgs e)
        {
            

            dgvVypujcene.DataSource = ((Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem).Vypujcene;
            SetButtons();
        }
        
        private void BtnVypujcit_Click(object sender, EventArgs e)
        {
            

           
            //má oprávnění si film půjčít-je pro něj film přístupný 
            int selectedDisk = dgvSklad.CurrentRow.Index;
            bool isCheck = (bool) dgvSklad.Rows[selectedDisk].Cells[3].Value;
            int selectedZakazník = dgvZakaznici.CurrentRow.Index;
            bool notCheck = (bool)dgvZakaznici.Rows[selectedZakazník].Cells[4].Value;
            if (isCheck == true &&  notCheck == false)
                {
                    MessageBox.Show("Není plnoletý. Nelze provést zápůjčku.");
                }
            else
            //v případě plnoletosti, nebo že si chce půjčit film bez nutnosti plnoletosti se zápůjčka provede
            {
                Databaze.Vypujcit(dgvZakaznici.CurrentRow.DataBoundItem, dgvSklad.CurrentRow.DataBoundItem);
                SetButtons();
            }
        }

        private void BtnVratit_Click(object sender, EventArgs e)
        {
            //vrátí zápůjčky pomocí metody vrátit
            Databaze.Vratit(dgvZakaznici.CurrentRow.DataBoundItem, dgvVypujcene.CurrentRow.DataBoundItem);
            SetButtons();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //v případě close form se uloží(viz. definice ve třídě databáze)
            Databaze.Serializuj();
        }
        //přdání nového zákazníka
        private void BtnNovyZakaznik_Click(object sender, EventArgs e)
        {

            zakaznikDialog.Action = ActionType.New;
            if (zakaznikDialog.ShowDialog() == DialogResult.OK)
            {
                Databaze.Zakaznici.Add(zakaznikDialog.CustomerInstance);
            }
        }
        //editace zákazníka
        private void BtnEditZakaznik_Click(object sender, EventArgs e)
        {
            zakaznikDialog.Action = ActionType.Edit;
            zakaznikDialog.CustomerInstance = (Zakaznik)dgvZakaznici.CurrentRow.DataBoundItem;
            zakaznikDialog.ShowDialog();
        }

        private void dgvZakaznici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
