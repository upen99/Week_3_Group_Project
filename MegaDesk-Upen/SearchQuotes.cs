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
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
