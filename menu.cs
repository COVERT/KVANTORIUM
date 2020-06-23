using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVANTORIUM
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formPREPOD = new PREPOD();
            formPREPOD.Show();
        }

        private void USINIK_Click(object sender, EventArgs e)
        {
            Form formUSINIK = new USINIK();
            formUSINIK.Show();
        }

        private void KURS_Click(object sender, EventArgs e)
        {
            Form formKURS = new KURS();
            formKURS.Show();
        }

        private void INFO_Click(object sender, EventArgs e)
        {
            Form formKONTAKT = new KONTAKT();
            formKONTAKT.Show();
        }
    }
}
