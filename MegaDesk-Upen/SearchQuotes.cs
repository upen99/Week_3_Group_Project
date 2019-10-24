using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MegaDesk_Upen;


namespace MegaDesk_Upen
{
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;
        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;


            var materials = Enum.GetValues(typeof(Surface))
                             .Cast<Surface>()
                             .ToList();

            cmbSurfaceMaterial.DataSource = materials;
            cmbSurfaceMaterial.SelectedIndex = -1;

        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            Surface surfaceMaterial = (Surface)combo.SelectedValue;

            if (combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid(surfaceMaterial);
            }
        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (var reader = new StreamReader(quotesFile))
            {
                // load existing quotes
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Data = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SuraceMaterial = d.Desk.SurfaceMaterial,
                    ShippingType = d.ShippingType,
                    QuoteAmount = d.QuotePrice.ToString("c")

                }).ToList();
            }
        }

        private void loadGrid(Surface surfaceMaterial)
        {
            var quotesFile = @"quotes.json";

            using (var reader = new StreamReader(quotesFile))
            {
                // load existing quotes
                string quotes = reader.ReadToEnd();

                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Data = d.QuoteDate,
                    Customer = d.CustomerName,
                    Depth = d.Desk.Depth,
                    Width = d.Desk.Width,
                    Drawers = d.Desk.NumberOfDrawers,
                    SuraceMaterial = d.Desk.SurfaceMaterial,
                    ShippingType = d.ShippingType,
                    QuoteAmount = d.QuotePrice.ToString("c")

                })
                    .Where(q => q.SuraceMaterial == surfaceMaterial)
                    .ToList();
            }
        }

    }

    }

 
