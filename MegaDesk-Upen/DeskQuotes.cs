using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Upen
{


   public class DeskQuotes
    {

        // declare const
        const decimal BASE_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSTWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;



        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public string ShippingType { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }


        // methods
        public decimal GetQuotePrice()
        {
            decimal runningTotal = 0;

            // add base price
            runningTotal = 200;

            
            // add surface area
            decimal surfaceArea = this.Desk.Width * this.Desk.Depth;
            
            var surfaceArePrice = 0M;
            if (surfaceArea > 1000)
            {
                surfaceArePrice = (surfaceArea - 100) * SURFACE_AREA_COST; //declare the const
            }

            runningTotal += surfaceArePrice;


            // add drawers
            var drawerCost = this.Desk.NumberOfDrawers * DRAWER_COST; //declare the const

            runningTotal += drawerCost;

            // add surface material
            var surfaceMaterialCost = 0m;

            switch (this.Desk.SurfaceMaterial)
            {
                case Surfacce.Oak:
                    surfaceMaterialCost = OAK_COST; //declare the const
                    break;

                case Surfae.Laminate: = LAMINATE_COST; //declare the const


            }


            // TODO: add logic to calculate price
            return 0;

        }

    }
}
