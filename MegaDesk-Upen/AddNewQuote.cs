﻿using System;
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

        MainMenu mainMenu;
       

        public AddNewQuote(MainMenu mainMenuForm)
        {
            InitializeComponent();

            //TODO: need to load surface material dropdpown from enum
            //TODO: need to load shipping dropdown from enum

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

        private void BtnGetQuote_Click(object sender, EventArgs e)
        {
            // STEP 1: create a Desk object and set all of its properties
            var desk = new Desk();

            desk.Depth = numDepth.Value;
            desk.Width = numWidth.Value;
            desk.NumberOfDrawers = (int)numNumberOfDrawers.Value;
            desk.SurfaceMaterial = (Surface)cmbSurfaceMaterial.SelectedItem;

            // STEP 2: create a DeskQuote object and set all of its properties
            var deskQuote = new DeskQuotes();
            deskQuote.CustomerName = txtCustomerName.Text;
            deskQuote.ShippingType = (Shipping)cmbDelivery.SelectedItem;
            deskQuote.QuoteDate = DateTime.Now;
            deskQuote.Desk = desk;

            // STEP 3: call the 'GetQuotePrice' method to calculate price and assign it to the 'QuotePrice' property of the DeskQuote object
            deskQuote.QuotePrice = deskQuote.GetQuotePrice();



            // STEP 4: write a new quote to the JSON file

        }
    }
}
