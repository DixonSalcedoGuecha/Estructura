using PRUEBA_FINAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Usuario
{
    public partial class frmDirectorio : Form
    {
        public frmDirectorio()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAjustes ajustes = new frmAjustes();
            ajustes.Show();
            this.Hide();
        }
    }
}
