using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FormaKlijent : Form
    {
        Komunikacija k;
        public FormaKlijent()
        {
            InitializeComponent();
        }

        private void FormaKlijent_Load(object sender, EventArgs e)
        {
            k = new Komunikacija();
            if (k.poveziSeNaServer())
            {
                this.Text = "Klijent je povezan na server";
            }
        }
    }
}
