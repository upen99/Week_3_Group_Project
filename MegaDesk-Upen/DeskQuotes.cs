using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Upen
{ 
    public enum Shipping
    {
        Rush3Day,
        Rush5Day,
        Rush7Day,
        NoRush
    }

   public class DeskQuotes
    {
        int[,] _rushOrderPrices;
        public DeskQuotes()
        {
            //TODO: load rush order shipping costs from rushOrderPrices.txt file into _rushOrderPrices

        }

        // declare const
        const decimal BASE_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;

        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Shipping ShippingType { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }


        // methods
        public decimal GetQuotePrice()
        {
            decimal runningTotal = 0;

            // add base price
            runningTotal = BASE_PRICE;

            
            // add surface area
            decimal surfaceArea = this.Desk.Width * this.Desk.Depth;
            
            var surfaceArePrice = 0M;
            if (surfaceArea > 1000)
            {
                surfaceArePrice = (surfaceArea - 1000) * SURFACE_AREA_COST; //declare the const
            }

            runningTotal += surfaceArePrice;


            // add drawers
            var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST; //declare the const

            runningTotal += drawerCost;

            // add surface material
            var surfaceMaterialCost = 0m;

            switch (this.Desk.SurfaceMaterial)
            {
                case Surface.Oak:
                    surfaceMaterialCost = OAK_COST; //declare the const
                    break;

                case Surface.Laminate:
                    surfaceMaterialCost = LAMINATE_COST; //declare the const
                    break;

                case Surface.Pine:
                    surfaceMaterialCost = PINE_COST; //declare the const
                    break;

                case Surface.Rosewood:
                    surfaceMaterialCost = ROSEWOOD_COST; //declare the const
                    break;

                case Surface.Veneer:
                    surfaceMaterialCost = VENEER_COST; //declare the const
                    break;
            }

            runningTotal += surfaceMaterialCost;

            //TODO: calculate shipping cost from rushOrderPrices.txt file
            switch(this.ShippingType)
            {
                case Shipping.Rush3Day:
                    //TODO: add rush3day price based on size to running total
                    //EXAMPLE: add _rushOrderPrices[0,0] to runningTotal variable
                    break;

                case Shipping.Rush5Day:
                    break;

                case Shipping.Rush7Day:
                    break;
            }


            



            // TODO: add logic to calculate price

            return 0;

        }

    }
}
