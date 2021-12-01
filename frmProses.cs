using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDesktop
{
    public partial class frmProses : Form
    {
        public delegate void CreateUpdateEventHandler(nilai besarnilai);
        public event CreateUpdateEventHandler onCreate;
        private nilai besarnilai;
        public frmProses()
        {
            InitializeComponent();
        }

        private void frmProses_Load(object sender, EventArgs e)
        {
            cmbProses.Items.Add("Penjumlahan");
            cmbProses.Items.Add("Pengurangan");
            cmbProses.Items.Add("Perkalian");
            cmbProses.Items.Add("Pembagian");            
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            besarnilai = new nilai();
            besarnilai.nilaiA = Convert.ToInt32(txtNilaia.Text);
            besarnilai.nilaiB = Convert.ToInt32(txtNilaib.Text);
            if(cmbProses.Text == "Penjumlahan")
            {
                besarnilai.hasil = besarnilai.nilaiA + besarnilai.nilaiB;
                besarnilai.modehitung = "Hasil penjumlahan " + Convert.ToString(besarnilai.nilaiA) + " + " + Convert.ToString(besarnilai.nilaiB) + " = " + Convert.ToString(besarnilai.hasil);
            }
            else if (cmbProses.Text == "Pengurangan")
            {
                besarnilai.hasil = besarnilai.nilaiA - besarnilai.nilaiB;
                besarnilai.modehitung = "Hasil pengurangan " + Convert.ToString(besarnilai.nilaiA) + " - " + Convert.ToString(besarnilai.nilaiB) + " = " + Convert.ToString(besarnilai.hasil);
            }
            else if (cmbProses.Text == "Perkalian")
            {
                besarnilai.hasil = besarnilai.nilaiA * besarnilai.nilaiB;
                besarnilai.modehitung = "Hasil perkalian " + Convert.ToString(besarnilai.nilaiA) + " * " + Convert.ToString(besarnilai.nilaiB) + " = " + Convert.ToString(besarnilai.hasil);
            }
            else if (cmbProses.Text == "Pembagian")
            {
                besarnilai.hasil = besarnilai.nilaiA / besarnilai.nilaiB;
                besarnilai.modehitung = "Hasil pembagian " + Convert.ToString(besarnilai.nilaiA) + " / " + Convert.ToString(besarnilai.nilaiB) + " = " + Convert.ToString(besarnilai.hasil);
            }
            onCreate(besarnilai);
        }
    }
}
