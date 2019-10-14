using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Upen
{
    public partial class AddNewQuote : Form
    {
        public AddNewQuote()
        {
            InitializeComponent();

        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            // show Main Menu form
            var mainMenue = (Form)this.Tag;
            mainMenue.Show();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
