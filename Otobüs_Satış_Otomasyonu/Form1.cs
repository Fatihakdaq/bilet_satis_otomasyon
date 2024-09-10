using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbOtobüs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbOtobüs.Text)
            {
                case "Travego":koltukdolur(8, false);
                        break;
                case "Man":koltukdolur(12, true);
                    break;
                case "Neoplan":koltukdolur(12, false);
                    break;

            }
            void koltukdolur(int sira,bool arkaBeslimi)
            {

            }
        }
    }
}
