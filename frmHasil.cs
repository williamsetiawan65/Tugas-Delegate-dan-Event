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
    public partial class frmHasil : Form
    {
        private IList<nilai> listOfNilai = new List<nilai>();
        public frmHasil()
        {
            InitializeComponent();
            lstHasil.View = View.List;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            frmProses proses = new frmProses();
            proses.onCreate += frmProses_onCreate;
            proses.ShowDialog();
        }

        private void frmProses_onCreate(nilai besarnilai)
        {
            listOfNilai.Add(besarnilai);
            ListViewItem item = new ListViewItem(besarnilai.modehitung);
            //Convert.ToString(besarnilai.hasil)
            lstHasil.Items.Add(item);
        }

        private void frmHasil_Load(object sender, EventArgs e)
        {            
        }
    }
}
